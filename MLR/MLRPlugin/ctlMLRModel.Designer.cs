﻿namespace MLRPlugin
{
    partial class ctlMLRModel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpData = new System.Windows.Forms.TabPage();
            this.dsControl1 = new VBCommon.Controls.DatasheetControl();
            this.tpVarSelection = new System.Windows.Forms.TabPage();
            this.ctlVariableSelection1 = new VBCommon.Controls.VariableSelection();
            this.tpModel = new System.Windows.Forms.TabPage();
            this.frmModel1 = new GALibForm.frmModel();
            this.tabControl1.SuspendLayout();
            this.tpData.SuspendLayout();
            this.tpVarSelection.SuspendLayout();
            this.tpModel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpData);
            this.tabControl1.Controls.Add(this.tpVarSelection);
            this.tabControl1.Controls.Add(this.tpModel);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tpData
            // 
            this.tpData.Controls.Add(this.dsControl1);
            this.tpData.Location = new System.Drawing.Point(4, 22);
            this.tpData.Name = "tpData";
            this.tpData.Padding = new System.Windows.Forms.Padding(3);
            this.tpData.Size = new System.Drawing.Size(972, 431);
            this.tpData.TabIndex = 0;
            this.tpData.Text = "Data Manipulation";
            this.tpData.UseVisualStyleBackColor = true;
            // 
            // dsControl1
            // 
            this.dsControl1.CurrentSelectedRowIndex = -1;
            this.dsControl1.DependentVariableTransform = VBCommon.Transforms.DependentVariableTransforms.none;
            this.dsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsControl1.DT = null;
            this.dsControl1.DTCI = null;
            this.dsControl1.DTRI = null;
            this.dsControl1.FileName = "";
            this.dsControl1.Location = new System.Drawing.Point(3, 3);
            this.dsControl1.Name = "dsControl1";
            this.dsControl1.Orientation = 0D;
            this.dsControl1.PowerTransformExponent = double.NaN;
            this.dsControl1.ResponseVarColIndex = 1;
            this.dsControl1.ResponseVarColName = "";
            this.dsControl1.ResponseVarColNameAsImported = "";
            this.dsControl1.SelectColName = "";
            this.dsControl1.SelectedColIndex = -1;
            this.dsControl1.Size = new System.Drawing.Size(966, 425);
            this.dsControl1.State = VBCommon.Controls.DatasheetControl.dtState.dirty;
            this.dsControl1.TabIndex = 0;
            // 
            // tpVarSelection
            // 
            this.tpVarSelection.AutoScroll = true;
            this.tpVarSelection.BackColor = System.Drawing.SystemColors.Control;
            this.tpVarSelection.Controls.Add(this.ctlVariableSelection1);
            this.tpVarSelection.Location = new System.Drawing.Point(4, 22);
            this.tpVarSelection.Name = "tpVarSelection";
            this.tpVarSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tpVarSelection.Size = new System.Drawing.Size(972, 431);
            this.tpVarSelection.TabIndex = 3;
            this.tpVarSelection.Text = "Variable Selection";
            // 
            // ctlVariableSelection1
            // 
            this.ctlVariableSelection1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ctlVariableSelection1.Location = new System.Drawing.Point(3, 6);
            this.ctlVariableSelection1.MinimumSize = new System.Drawing.Size(500, 0);
            this.ctlVariableSelection1.Name = "ctlVariableSelection1";
            this.ctlVariableSelection1.Size = new System.Drawing.Size(500, 17);
            this.ctlVariableSelection1.TabIndex = 0;
            // 
            // tpModel
            // 
            this.tpModel.Controls.Add(this.frmModel1);
            this.tpModel.Location = new System.Drawing.Point(4, 22);
            this.tpModel.Name = "tpModel";
            this.tpModel.Size = new System.Drawing.Size(972, 431);
            this.tpModel.TabIndex = 2;
            this.tpModel.Text = "Model";
            this.tpModel.UseVisualStyleBackColor = true;
            // 
            // frmModel1
            // 
            this.frmModel1.DepVarTrans = VBCommon.Transforms.DependentVariableTransforms.none;
            this.frmModel1.DepVarTransExp = 1D;
            this.frmModel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmModel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmModel1.Location = new System.Drawing.Point(0, 0);
            this.frmModel1.Name = "frmModel1";
            this.frmModel1.SelectedVariables = null;
            this.frmModel1.Size = new System.Drawing.Size(972, 431);
            this.frmModel1.TabIndex = 0;
            // 
            // ctlMLRModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ctlMLRModel";
            this.Size = new System.Drawing.Size(980, 457);
            this.tabControl1.ResumeLayout(false);
            this.tpData.ResumeLayout(false);
            this.tpVarSelection.ResumeLayout(false);
            this.tpModel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpData;
        private System.Windows.Forms.TabPage tpModel;
        private VBCommon.Controls.DatasheetControl dsControl1;
        private System.Windows.Forms.TabPage tpVarSelection;
        private GALibForm.frmModel frmModel1;
        private VBCommon.Controls.VariableSelection ctlVariableSelection1;
    }
}