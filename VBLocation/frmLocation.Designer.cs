﻿namespace VBLocation
{
   partial class frmLocation
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
         if(disposing && (components != null))
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
          this.label7 = new System.Windows.Forms.Label();
          this.comboBoxMapType = new System.Windows.Forms.ComboBox();
          this.groupBox4 = new System.Windows.Forms.GroupBox();
          this.MainMap = new VBLocation.Map();
          this.button1 = new System.Windows.Forms.Button();
          this.groupBox3 = new System.Windows.Forms.GroupBox();
          this.btnGoPlace = new System.Windows.Forms.Button();
          this.label6 = new System.Windows.Forms.Label();
          this.textBoxGeo = new System.Windows.Forms.TextBox();
          this.btnGoLatLng = new System.Windows.Forms.Button();
          this.label2 = new System.Windows.Forms.Label();
          this.label1 = new System.Windows.Forms.Label();
          this.textBoxLng = new System.Windows.Forms.TextBox();
          this.textBoxLat = new System.Windows.Forms.TextBox();
          this.trackBar1 = new System.Windows.Forms.TrackBar();
          this.groupBox2 = new System.Windows.Forms.GroupBox();
          this.groupBox5 = new System.Windows.Forms.GroupBox();
          this.groupBoxLoading = new System.Windows.Forms.GroupBox();
          this.progressBar3 = new System.Windows.Forms.ProgressBar();
          this.progressBar2 = new System.Windows.Forms.ProgressBar();
          this.progressBar1 = new System.Windows.Forms.ProgressBar();
          this.groupBox8 = new System.Windows.Forms.GroupBox();
          this.btnBeachMarker = new System.Windows.Forms.Button();
          this.btnSelectWater = new System.Windows.Forms.Button();
          this.btnBeachMarker2 = new System.Windows.Forms.Button();
          this.label5 = new System.Windows.Forms.Label();
          this.txtBeachAngle = new System.Windows.Forms.TextBox();
          this.btnShowDataSources = new System.Windows.Forms.Button();
          this.groupBox6 = new System.Windows.Forms.GroupBox();
          this.textBoxCurrLng = new System.Windows.Forms.TextBox();
          this.textBoxCurrLat = new System.Windows.Forms.TextBox();
          this.label13 = new System.Windows.Forms.Label();
          this.label14 = new System.Windows.Forms.Label();
          this.cbnwis = new System.Windows.Forms.CheckBox();
          this.cbstoret = new System.Windows.Forms.CheckBox();
          this.cbncdc = new System.Windows.Forms.CheckBox();
          this.btnClearStations = new System.Windows.Forms.Button();
          this.helpProvider1 = new System.Windows.Forms.HelpProvider();
          this.groupBox4.SuspendLayout();
          this.groupBox3.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
          this.groupBox2.SuspendLayout();
          this.groupBox5.SuspendLayout();
          this.groupBoxLoading.SuspendLayout();
          this.groupBox8.SuspendLayout();
          this.groupBox6.SuspendLayout();
          this.SuspendLayout();
          // 
          // label7
          // 
          this.label7.AutoSize = true;
          this.label7.Location = new System.Drawing.Point(17, 29);
          this.label7.Name = "label7";
          this.label7.Size = new System.Drawing.Size(31, 13);
          this.label7.TabIndex = 31;
          this.label7.Text = "Type";
          // 
          // comboBoxMapType
          // 
          this.comboBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.comboBoxMapType.FormattingEnabled = true;
          this.comboBoxMapType.Location = new System.Drawing.Point(20, 45);
          this.comboBoxMapType.Name = "comboBoxMapType";
          this.comboBoxMapType.Size = new System.Drawing.Size(125, 21);
          this.comboBoxMapType.TabIndex = 9;
          this.comboBoxMapType.DropDownClosed += new System.EventHandler(this.comboBoxMapType_DropDownClosed);
          // 
          // groupBox4
          // 
          this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.groupBox4.Controls.Add(this.MainMap);
          this.groupBox4.Location = new System.Drawing.Point(263, 12);
          this.groupBox4.Name = "groupBox4";
          this.groupBox4.Size = new System.Drawing.Size(595, 717);
          this.groupBox4.TabIndex = 27;
          this.groupBox4.TabStop = false;
          // 
          // MainMap
          // 
          this.MainMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.MainMap.BackColor = System.Drawing.SystemColors.AppWorkspace;
          this.MainMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.MainMap.CanDragMap = true;
          this.MainMap.ForeColor = System.Drawing.SystemColors.ControlText;
          this.MainMap.Location = new System.Drawing.Point(6, 16);
          this.MainMap.MarkersEnabled = true;
          this.MainMap.Name = "MainMap";
          this.MainMap.Size = new System.Drawing.Size(583, 692);
          this.MainMap.TabIndex = 0;
          // 
          // button1
          // 
          this.button1.Location = new System.Drawing.Point(50, 80);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(53, 24);
          this.button1.TabIndex = 9;
          this.button1.Text = "Reload";
          this.button1.UseVisualStyleBackColor = true;
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // groupBox3
          // 
          this.groupBox3.Controls.Add(this.btnGoPlace);
          this.groupBox3.Controls.Add(this.label6);
          this.groupBox3.Controls.Add(this.textBoxGeo);
          this.groupBox3.Controls.Add(this.btnGoLatLng);
          this.groupBox3.Controls.Add(this.label2);
          this.groupBox3.Controls.Add(this.label1);
          this.groupBox3.Controls.Add(this.textBoxLng);
          this.groupBox3.Controls.Add(this.textBoxLat);
          this.groupBox3.Location = new System.Drawing.Point(14, 12);
          this.groupBox3.Name = "groupBox3";
          this.groupBox3.Size = new System.Drawing.Size(169, 164);
          this.groupBox3.TabIndex = 28;
          this.groupBox3.TabStop = false;
          this.groupBox3.Text = "Map Controls";
          // 
          // btnGoPlace
          // 
          this.btnGoPlace.Location = new System.Drawing.Point(6, 130);
          this.btnGoPlace.Name = "btnGoPlace";
          this.btnGoPlace.Size = new System.Drawing.Size(83, 24);
          this.btnGoPlace.TabIndex = 12;
          this.btnGoPlace.Text = "GoTo Place";
          this.btnGoPlace.UseVisualStyleBackColor = true;
          this.btnGoPlace.Click += new System.EventHandler(this.button3_Click_1);
          // 
          // label6
          // 
          this.label6.AutoSize = true;
          this.label6.Location = new System.Drawing.Point(132, 111);
          this.label6.Name = "label6";
          this.label6.Size = new System.Drawing.Size(34, 13);
          this.label6.TabIndex = 11;
          this.label6.Text = "Place";
          // 
          // textBoxGeo
          // 
          this.textBoxGeo.Location = new System.Drawing.Point(6, 104);
          this.textBoxGeo.Name = "textBoxGeo";
          this.textBoxGeo.Size = new System.Drawing.Size(125, 20);
          this.textBoxGeo.TabIndex = 10;
          this.textBoxGeo.Text = "Athens, GA";
          this.textBoxGeo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGeo_KeyPress);
          // 
          // btnGoLatLng
          // 
          this.btnGoLatLng.Location = new System.Drawing.Point(7, 74);
          this.btnGoLatLng.Name = "btnGoLatLng";
          this.btnGoLatLng.Size = new System.Drawing.Size(83, 24);
          this.btnGoLatLng.TabIndex = 8;
          this.btnGoLatLng.Text = "GoTo Lat/Lng";
          this.btnGoLatLng.UseVisualStyleBackColor = true;
          this.btnGoLatLng.Click += new System.EventHandler(this.button8_Click);
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(132, 51);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(25, 13);
          this.label2.TabIndex = 3;
          this.label2.Text = "Lng";
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(132, 25);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(22, 13);
          this.label1.TabIndex = 2;
          this.label1.Text = "Lat";
          // 
          // textBoxLng
          // 
          this.textBoxLng.Location = new System.Drawing.Point(6, 48);
          this.textBoxLng.Name = "textBoxLng";
          this.textBoxLng.Size = new System.Drawing.Size(125, 20);
          this.textBoxLng.TabIndex = 1;
          // 
          // textBoxLat
          // 
          this.textBoxLat.Location = new System.Drawing.Point(6, 22);
          this.textBoxLat.Name = "textBoxLat";
          this.textBoxLat.Size = new System.Drawing.Size(125, 20);
          this.textBoxLat.TabIndex = 0;
          // 
          // trackBar1
          // 
          this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.trackBar1.LargeChange = 1;
          this.trackBar1.Location = new System.Drawing.Point(3, 16);
          this.trackBar1.Maximum = 17;
          this.trackBar1.Minimum = 1;
          this.trackBar1.Name = "trackBar1";
          this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
          this.trackBar1.Size = new System.Drawing.Size(45, 672);
          this.trackBar1.TabIndex = 29;
          this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
          this.trackBar1.Value = 12;
          this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
          // 
          // groupBox2
          // 
          this.groupBox2.Controls.Add(this.trackBar1);
          this.groupBox2.Location = new System.Drawing.Point(189, 12);
          this.groupBox2.Name = "groupBox2";
          this.groupBox2.Size = new System.Drawing.Size(68, 691);
          this.groupBox2.TabIndex = 30;
          this.groupBox2.TabStop = false;
          this.groupBox2.Text = "Zoom";
          // 
          // groupBox5
          // 
          this.groupBox5.Controls.Add(this.button1);
          this.groupBox5.Controls.Add(this.label7);
          this.groupBox5.Controls.Add(this.comboBoxMapType);
          this.groupBox5.Location = new System.Drawing.Point(14, 182);
          this.groupBox5.Name = "groupBox5";
          this.groupBox5.Size = new System.Drawing.Size(169, 126);
          this.groupBox5.TabIndex = 31;
          this.groupBox5.TabStop = false;
          this.groupBox5.Text = "Map Settings";
          // 
          // groupBoxLoading
          // 
          this.groupBoxLoading.Controls.Add(this.progressBar3);
          this.groupBoxLoading.Controls.Add(this.progressBar2);
          this.groupBoxLoading.Controls.Add(this.progressBar1);
          this.groupBoxLoading.Location = new System.Drawing.Point(14, 655);
          this.groupBoxLoading.Name = "groupBoxLoading";
          this.groupBoxLoading.Size = new System.Drawing.Size(169, 48);
          this.groupBoxLoading.TabIndex = 36;
          this.groupBoxLoading.TabStop = false;
          this.groupBoxLoading.Text = "loading";
          // 
          // progressBar3
          // 
          this.progressBar3.Location = new System.Drawing.Point(110, 19);
          this.progressBar3.Name = "progressBar3";
          this.progressBar3.Size = new System.Drawing.Size(53, 20);
          this.progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
          this.progressBar3.TabIndex = 2;
          this.progressBar3.Visible = false;
          // 
          // progressBar2
          // 
          this.progressBar2.Location = new System.Drawing.Point(59, 19);
          this.progressBar2.Name = "progressBar2";
          this.progressBar2.Size = new System.Drawing.Size(53, 20);
          this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
          this.progressBar2.TabIndex = 1;
          this.progressBar2.Visible = false;
          // 
          // progressBar1
          // 
          this.progressBar1.Location = new System.Drawing.Point(6, 19);
          this.progressBar1.Name = "progressBar1";
          this.progressBar1.Size = new System.Drawing.Size(53, 20);
          this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
          this.progressBar1.TabIndex = 0;
          this.progressBar1.Visible = false;
          // 
          // groupBox8
          // 
          this.groupBox8.Controls.Add(this.btnBeachMarker);
          this.groupBox8.Controls.Add(this.btnSelectWater);
          this.groupBox8.Controls.Add(this.btnBeachMarker2);
          this.groupBox8.Controls.Add(this.label5);
          this.groupBox8.Controls.Add(this.txtBeachAngle);
          this.groupBox8.Location = new System.Drawing.Point(14, 314);
          this.groupBox8.Name = "groupBox8";
          this.groupBox8.Size = new System.Drawing.Size(169, 144);
          this.groupBox8.TabIndex = 37;
          this.groupBox8.TabStop = false;
          this.groupBox8.Text = "Beach Orientation";
          // 
          // btnBeachMarker
          // 
          this.btnBeachMarker.Location = new System.Drawing.Point(9, 19);
          this.btnBeachMarker.Name = "btnBeachMarker";
          this.btnBeachMarker.Size = new System.Drawing.Size(142, 24);
          this.btnBeachMarker.TabIndex = 18;
          this.btnBeachMarker.Text = "Add 1st Beach Marker";
          this.btnBeachMarker.UseVisualStyleBackColor = true;
          this.btnBeachMarker.Click += new System.EventHandler(this.btnBeachMarker_Click);
          // 
          // btnSelectWater
          // 
          this.btnSelectWater.Location = new System.Drawing.Point(7, 78);
          this.btnSelectWater.Name = "btnSelectWater";
          this.btnSelectWater.Size = new System.Drawing.Size(142, 23);
          this.btnSelectWater.TabIndex = 17;
          this.btnSelectWater.Text = "Add Water Marker";
          this.btnSelectWater.UseVisualStyleBackColor = true;
          this.btnSelectWater.Click += new System.EventHandler(this.btnSelectWater_Click);
          // 
          // btnBeachMarker2
          // 
          this.btnBeachMarker2.Location = new System.Drawing.Point(7, 49);
          this.btnBeachMarker2.Name = "btnBeachMarker2";
          this.btnBeachMarker2.Size = new System.Drawing.Size(142, 23);
          this.btnBeachMarker2.TabIndex = 16;
          this.btnBeachMarker2.Text = "Add 2nd Beach Marker";
          this.btnBeachMarker2.UseVisualStyleBackColor = true;
          this.btnBeachMarker2.Click += new System.EventHandler(this.btnBeachMarker2_Click);
          // 
          // label5
          // 
          this.label5.AutoSize = true;
          this.label5.Location = new System.Drawing.Point(6, 124);
          this.label5.Name = "label5";
          this.label5.Size = new System.Drawing.Size(92, 13);
          this.label5.TabIndex = 6;
          this.label5.Text = "Beach Orientation";
          // 
          // txtBeachAngle
          // 
          this.txtBeachAngle.Location = new System.Drawing.Point(105, 118);
          this.txtBeachAngle.Name = "txtBeachAngle";
          this.txtBeachAngle.Size = new System.Drawing.Size(49, 20);
          this.txtBeachAngle.TabIndex = 3;
          // 
          // btnShowDataSources
          // 
          this.btnShowDataSources.Location = new System.Drawing.Point(23, 476);
          this.btnShowDataSources.Name = "btnShowDataSources";
          this.btnShowDataSources.Size = new System.Drawing.Size(140, 26);
          this.btnShowDataSources.TabIndex = 39;
          this.btnShowDataSources.Text = "Show Station Locations";
          this.btnShowDataSources.UseVisualStyleBackColor = true;
          this.btnShowDataSources.Click += new System.EventHandler(this.btnShowDataSources_Click);
          // 
          // groupBox6
          // 
          this.groupBox6.Controls.Add(this.textBoxCurrLng);
          this.groupBox6.Controls.Add(this.textBoxCurrLat);
          this.groupBox6.Controls.Add(this.label13);
          this.groupBox6.Controls.Add(this.label14);
          this.groupBox6.Location = new System.Drawing.Point(14, 574);
          this.groupBox6.Name = "groupBox6";
          this.groupBox6.Size = new System.Drawing.Size(152, 75);
          this.groupBox6.TabIndex = 40;
          this.groupBox6.TabStop = false;
          this.groupBox6.Text = "Current Location";
          // 
          // textBoxCurrLng
          // 
          this.textBoxCurrLng.Location = new System.Drawing.Point(6, 46);
          this.textBoxCurrLng.Name = "textBoxCurrLng";
          this.textBoxCurrLng.ReadOnly = true;
          this.textBoxCurrLng.Size = new System.Drawing.Size(111, 20);
          this.textBoxCurrLng.TabIndex = 9;
          // 
          // textBoxCurrLat
          // 
          this.textBoxCurrLat.Location = new System.Drawing.Point(6, 20);
          this.textBoxCurrLat.Name = "textBoxCurrLat";
          this.textBoxCurrLat.ReadOnly = true;
          this.textBoxCurrLat.Size = new System.Drawing.Size(111, 20);
          this.textBoxCurrLat.TabIndex = 8;
          // 
          // label13
          // 
          this.label13.AutoSize = true;
          this.label13.Location = new System.Drawing.Point(117, 49);
          this.label13.Name = "label13";
          this.label13.Size = new System.Drawing.Size(25, 13);
          this.label13.TabIndex = 11;
          this.label13.Text = "Lng";
          // 
          // label14
          // 
          this.label14.AutoSize = true;
          this.label14.Location = new System.Drawing.Point(117, 23);
          this.label14.Name = "label14";
          this.label14.Size = new System.Drawing.Size(22, 13);
          this.label14.TabIndex = 10;
          this.label14.Text = "Lat";
          // 
          // cbnwis
          // 
          this.cbnwis.AutoSize = true;
          this.cbnwis.Location = new System.Drawing.Point(23, 509);
          this.cbnwis.Name = "cbnwis";
          this.cbnwis.Size = new System.Drawing.Size(55, 17);
          this.cbnwis.TabIndex = 41;
          this.cbnwis.Text = "NWIS";
          this.cbnwis.UseVisualStyleBackColor = true;
          // 
          // cbstoret
          // 
          this.cbstoret.AutoSize = true;
          this.cbstoret.Location = new System.Drawing.Point(23, 523);
          this.cbstoret.Name = "cbstoret";
          this.cbstoret.Size = new System.Drawing.Size(70, 17);
          this.cbstoret.TabIndex = 42;
          this.cbstoret.Text = "STORET";
          this.cbstoret.UseVisualStyleBackColor = true;
          // 
          // cbncdc
          // 
          this.cbncdc.AutoSize = true;
          this.cbncdc.Location = new System.Drawing.Point(103, 508);
          this.cbncdc.Name = "cbncdc";
          this.cbncdc.Size = new System.Drawing.Size(56, 17);
          this.cbncdc.TabIndex = 43;
          this.cbncdc.Text = "NCDC";
          this.cbncdc.UseVisualStyleBackColor = true;
          // 
          // btnClearStations
          // 
          this.btnClearStations.Location = new System.Drawing.Point(21, 542);
          this.btnClearStations.Name = "btnClearStations";
          this.btnClearStations.Size = new System.Drawing.Size(142, 26);
          this.btnClearStations.TabIndex = 44;
          this.btnClearStations.Text = "Remove Station Locations";
          this.btnClearStations.UseVisualStyleBackColor = true;
          this.btnClearStations.Click += new System.EventHandler(this.btnClearStations_Click);
          // 
          // frmLocation
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.AutoScroll = true;
          this.AutoScrollMargin = new System.Drawing.Size(2, 2);
          this.AutoScrollMinSize = new System.Drawing.Size(10, 800);
          this.BackColor = System.Drawing.SystemColors.ControlLight;
          this.Controls.Add(this.btnClearStations);
          this.Controls.Add(this.cbncdc);
          this.Controls.Add(this.cbstoret);
          this.Controls.Add(this.cbnwis);
          this.Controls.Add(this.groupBox6);
          this.Controls.Add(this.btnShowDataSources);
          this.Controls.Add(this.groupBox8);
          this.Controls.Add(this.groupBoxLoading);
          this.Controls.Add(this.groupBox5);
          this.Controls.Add(this.groupBox3);
          this.Controls.Add(this.groupBox2);
          this.Controls.Add(this.groupBox4);
          this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.MinimumSize = new System.Drawing.Size(556, 738);
          this.Name = "frmLocation";
          this.Size = new System.Drawing.Size(895, 738);
          this.Load += new System.EventHandler(this.frmLocation_Load);
          this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmLocation_HelpRequested);
          this.groupBox4.ResumeLayout(false);
          this.groupBox3.ResumeLayout(false);
          this.groupBox3.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
          this.groupBox2.ResumeLayout(false);
          this.groupBox2.PerformLayout();
          this.groupBox5.ResumeLayout(false);
          this.groupBox5.PerformLayout();
          this.groupBoxLoading.ResumeLayout(false);
          this.groupBox8.ResumeLayout(false);
          this.groupBox8.PerformLayout();
          this.groupBox6.ResumeLayout(false);
          this.groupBox6.PerformLayout();
          this.ResumeLayout(false);
          this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBoxLng;
      private System.Windows.Forms.TextBox textBoxLat;
      private System.Windows.Forms.Button btnGoLatLng;
      private Map MainMap;
      private System.Windows.Forms.ComboBox comboBoxMapType;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TrackBar trackBar1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.GroupBox groupBox5;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox textBoxGeo;
      private System.Windows.Forms.GroupBox groupBoxLoading;
      private System.Windows.Forms.ProgressBar progressBar1;
      private System.Windows.Forms.ProgressBar progressBar3;
      private System.Windows.Forms.ProgressBar progressBar2;
      private System.Windows.Forms.GroupBox groupBox8;
      private System.Windows.Forms.TextBox txtBeachAngle;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button btnGoPlace;
      private System.Windows.Forms.Button btnSelectWater;
      private System.Windows.Forms.Button btnBeachMarker2;
      private System.Windows.Forms.Button btnBeachMarker;
      private System.Windows.Forms.Button btnShowDataSources;
      private System.Windows.Forms.GroupBox groupBox6;
      private System.Windows.Forms.TextBox textBoxCurrLng;
      private System.Windows.Forms.TextBox textBoxCurrLat;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.CheckBox cbnwis;
      private System.Windows.Forms.CheckBox cbstoret;
      private System.Windows.Forms.CheckBox cbncdc;
      private System.Windows.Forms.Button btnClearStations;
      private System.Windows.Forms.HelpProvider helpProvider1;
   }
}

