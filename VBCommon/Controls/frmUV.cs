﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VBCommon;

namespace VBCommon.Controls
{
    /// <summary>
    /// class allows user selection of named wind and/or current variables, magnitude and direction,
    /// and calculates their associated along-shore and on-shore orthogonal components reative to
    /// a user supplied beach orientation angle that was previously generated and saved, or is typed-in
    /// here.  these A and O decompositional components are stored as datatable columns to be added into
    /// the users' dataset for consideratin in model building.  reference schemes and conventions are 
    /// documented in the application users guide. further information can also be found in the 
    /// vbtools.watercurrentcomponents and vbtools.windcomponents classes.
    /// </summary>
    public partial class frmUV : Form
    {
        private DataTable _dt = null;
        private string _rvname = string.Empty;
        private string _dtsname = string.Empty;
        //private VBProjectManager _proj = null;
        private double _bo = 0;
        private List<string> _colsadded = null;

        /// <summary>
        /// class contructor expects a table to operate on, the dependent variable and the date/timestamp
        /// variable names (so as not to list them for selection)
        /// </summary>
        /// <param name="dt">table to operate on</param>
        /// <param name="dvname">response variable name</param>
        /// <param name="dtsname">datetimestamp column name</param>
        public frmUV(DataTable dt, string dvname, string dtsname, double orientation)
        {
            InitializeComponent();

            if (dt == null) this.Close();

            _colsadded = new List<string>();

            _dt = dt.Copy();
            _rvname = dvname;
            _dtsname = dtsname;
            initcbs();
            /*_proj = VBProjectManager.GetProjectManager();
            
            if (_proj.SiteInfo != null)
            {
                _bo = _proj.SiteInfo.Orientation;
            }*/
            txtRotationAngle.Text = _bo.ToString();
        }

        /// <summary>
        /// accessor for table containing decomposition elements
        /// </summary>
        public DataTable WCDT
        {
            get { return _dt; }
        }

        /// <summary>
        /// accessor containing list of columns names of decompositional data
        /// </summary>
        public List<string> WCColsAdded
        {
            get { return _colsadded; }
        }

        /// <summary>
        /// load the list boxs with variable names for user selection 
        /// (to identify wind/current magnitude/direction)
        /// </summary>
        private void initcbs()
        {
            foreach (DataColumn c in _dt.Columns)
            {
                if (c.ColumnName == _rvname || c.ColumnName == _dtsname) continue;
                if (c.ColumnName != null && c.ColumnName != "")
                {
                    cbWindDirectionColumn.Items.Add(c.ColumnName);
                    cbWindSpeedColumn.Items.Add(c.ColumnName);
                    cbCurrentDirectionColumn.Items.Add(c.ColumnName);
                    cbCurrentSpeedColumn.Items.Add(c.ColumnName);
                }
            }
     
        }

        /// <summary>
        /// button ok clicked, calculate A/O components, save data and return (if ok, otherwise, stay here)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (_dt.Rows.Count < 1) return;

            if (cbWindDirectionColumn.SelectedIndex >= 0 && cbWindSpeedColumn.SelectedIndex >= 0)
            {

                VBCommon.Spatial.WindComponents wc = new VBCommon.Spatial.WindComponents(_dt, cbWindSpeedColumn.SelectedItem.ToString(),
                    cbWindDirectionColumn.SelectedItem.ToString(), _bo);
                if (!wc.Message.Equals("OK"))
                {
                    showmessage("WIND: ");
                    return;
                }
                else
                {
                    _dt = wc.DT;
                    foreach (string s in wc.WCompColNamesAdded)
                    {
                        _colsadded.Add(s);
                    }
                    //_colsadded = wc.WCompColNamesAdded;
                    //_colsadded.Add (wc.WindDirectionColumnName);//.ToString();
                    //_colsadded.Add (wc.WindSpeedColumnName);//.ToString();
                    //_colsadded.Add("Wind A-Comp");
                    //_colsadded.Add("Wind O-Comp");
                }
            }
            else
            {
                if (cbCurrentDirectionColumn.SelectedIndex < 0 && cbCurrentSpeedColumn.SelectedIndex < 0)
                    return;
            }

            if (cbCurrentDirectionColumn.SelectedIndex >= 0 && cbCurrentSpeedColumn.SelectedIndex >= 0)
            {
                //CurrentComponents cc = new CurrentComponents(_dt, cbCurrentSpeedColumn.SelectedItem.ToString(),
                //    cbCurrentDirectionColumn.SelectedItem.ToString(), _bo);
                VBCommon.Spatial.WaterCurrentComponents cc = new VBCommon.Spatial.WaterCurrentComponents(_dt, cbCurrentSpeedColumn.SelectedItem.ToString(),
                    cbCurrentDirectionColumn.SelectedItem.ToString(), _bo);
                if (!cc.Message.Equals("OK"))
                {
                    showmessage("CURRENT: ");
                    return;
                }
                else
                {
                    _dt = cc.DT;
                    foreach (string s in cc.CCompColNamesAdded)
                    {
                        _colsadded.Add(s);
                    }
                    //_colsadded = cc.CCompColNamesAdded;
                    //_colsadded.Add(cc.CurrentSpeedColName);
                    //_colsadded.Add("Current A-Comp");
                    //_colsadded.Add("Current O-comp");
                }

            }
            else
            {
                if (cbWindDirectionColumn.SelectedIndex < 0 && cbWindSpeedColumn.SelectedIndex < 0)
                    return;
            }

            ////mark created cols as decomposition
            //foreach (DataColumn c in _dtCopy.Columns)
            //{
            //    if (!c.ExtendedProperties.Contains(VBTools.Globals.MAINEFFECT.ToString()))

            //        c.ExtendedProperties[VBTools.Globals.DECOMPOSITION] = true;
            //}

            _dt.AcceptChanges();

            Close();
        }

        /// <summary>
        /// calculation error message
        /// </summary>
        /// <param name="proc"></param>
        private void showmessage(string proc)
        {
            MessageBox.Show("Problem accessing or converting wind/current speed/direction data. (See log file for details.)",
                proc + "Correct columns selected?", MessageBoxButtons.OK);
        }

        /// <summary>
        /// leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// beach angle validation of what users entered - clear any error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRotationAngle_Validated(object sender, EventArgs e)
        {
            //rorProvider1.Clear();
            //or
            errorProvider1.SetError(txtRotationAngle,"");
        }

        /// <summary>
        /// beach angle validation of what users entered - error or save the number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRotationAngle_Validating(object sender, CancelEventArgs e)
        {
            double bo;
            if (!double.TryParse(txtRotationAngle.Text, out bo))
            {
                e.Cancel = true;
                txtRotationAngle.Select(0, txtRotationAngle.Text.Length);
                this.errorProvider1.SetError(txtRotationAngle, "Text must convert to a number.");
            }
            else
            {
                _bo = bo;
            }
        }

        private void frmUV_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string apppath = Application.StartupPath.ToString();
            VBCSHelp help = new VBCSHelp(apppath, sender);
            if (!help.Status)
            {
                MessageBox.Show(
                "User documentation is found in the Documentation folder where you installed Virtual Beach"
                + "\nIf your web browser is PDF-enabled, open the User Guide with your browser.",
                "Neither Adobe Acrobat nor Adobe Reader found.",
                MessageBoxButtons.OK);
            }
        }

    }
}
