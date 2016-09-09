namespace ProfilometerAutomation
{
    public partial class Form1
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
            public void InitializeComponent()
            {
            this.gwComs1 = new GalilWidgets.GWComs();
            this.gwDatRec1 = new GalilWidgets.GWDatRec();
            this.gwDatRec2 = new GalilWidgets.GWDatRec();
            this.gwSettings1 = new GalilWidgets.GWSettings();
            this.gwTerm1 = new GalilWidgets.GWTerm();
            this.gwPoll1 = new GalilWidgets.GWPoll();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.cboHandShaking = new System.Windows.Forms.ComboBox();
            this.txtCommand = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLengthBetweenPointsX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbIncoming = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.XlExportButton = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnPortState = new System.Windows.Forms.Button();
            this.btnPorts = new System.Windows.Forms.Button();
            this.checkBoxManualSetting = new System.Windows.Forms.CheckBox();
            this.comboBoxMeasurePoints = new System.Windows.Forms.ComboBox();
            this.textBoxLengthBetweenPointsDegrees = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRotations = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gwComs1
            // 
            this.gwComs1.Location = new System.Drawing.Point(3, 3);
            this.gwComs1.Name = "gwComs1";
            this.gwComs1.Size = new System.Drawing.Size(360, 149);
            this.gwComs1.TabIndex = 0;
            this.gwComs1.Message += new GalilWidgets.GWComs.MessageEventHandler(this.Message);
            // 
            // gwDatRec1
            // 
            this.gwDatRec1.Enabled = false;
            this.gwDatRec1.GWFlowVertical = true;
            this.gwDatRec1.GWTitle = "";
            this.gwDatRec1.GWWrap = true;
            this.gwDatRec1.Location = new System.Drawing.Point(3, 158);
            this.gwDatRec1.Name = "gwDatRec1";
            this.gwDatRec1.Size = new System.Drawing.Size(624, 353);
            this.gwDatRec1.TabIndex = 1;
            // 
            // gwDatRec2
            // 
            this.gwDatRec2.Enabled = false;
            this.gwDatRec2.GWFlowVertical = true;
            this.gwDatRec2.GWTitle = "";
            this.gwDatRec2.GWWrap = true;
            this.gwDatRec2.Location = new System.Drawing.Point(560, 3);
            this.gwDatRec2.Name = "gwDatRec2";
            this.gwDatRec2.Size = new System.Drawing.Size(430, 149);
            this.gwDatRec2.TabIndex = 2;
            // 
            // gwSettings1
            // 
            this.gwSettings1.AutoScroll = true;
            this.gwSettings1.Enabled = false;
            this.gwSettings1.Location = new System.Drawing.Point(3, 517);
            this.gwSettings1.Name = "gwSettings1";
            this.gwSettings1.Size = new System.Drawing.Size(987, 102);
            this.gwSettings1.TabIndex = 4;
            // 
            // gwTerm1
            // 
            this.gwTerm1.Enabled = false;
            this.gwTerm1.Location = new System.Drawing.Point(633, 158);
            this.gwTerm1.Name = "gwTerm1";
            this.gwTerm1.Size = new System.Drawing.Size(357, 353);
            this.gwTerm1.TabIndex = 5;
            // 
            // gwPoll1
            // 
            this.gwPoll1.Enabled = false;
            this.gwPoll1.GWPollingInterval = 100;
            this.gwPoll1.Location = new System.Drawing.Point(369, 3);
            this.gwPoll1.Name = "gwPoll1";
            this.gwPoll1.Size = new System.Drawing.Size(185, 149);
            this.gwPoll1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.87845F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.12155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 433F));
            this.tableLayoutPanel1.Controls.Add(this.cboPorts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboBaudRate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboDataBits, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboStopBits, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboParity, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboHandShaking, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtCommand, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLengthBetweenPointsX, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbIncoming, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.XlExportButton, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnHello, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPortState, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPorts, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxManualSetting, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxMeasurePoints, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLengthBetweenPointsDegrees, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRotations, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 625);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.70422F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.29578F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(987, 195);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(111, 3);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(60, 21);
            this.cboPorts.TabIndex = 15;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Location = new System.Drawing.Point(111, 34);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(60, 21);
            this.cboBaudRate.TabIndex = 16;
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Location = new System.Drawing.Point(111, 64);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(60, 21);
            this.cboDataBits.TabIndex = 17;
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(111, 91);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(60, 21);
            this.cboStopBits.TabIndex = 18;
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(111, 117);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(60, 21);
            this.cboParity.TabIndex = 19;
            // 
            // cboHandShaking
            // 
            this.cboHandShaking.FormattingEnabled = true;
            this.cboHandShaking.Location = new System.Drawing.Point(111, 169);
            this.cboHandShaking.Name = "cboHandShaking";
            this.cboHandShaking.Size = new System.Drawing.Size(60, 21);
            this.cboHandShaking.TabIndex = 20;
            // 
            // txtCommand
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCommand, 3);
            this.txtCommand.Location = new System.Drawing.Point(410, 3);
            this.txtCommand.Multiline = false;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(214, 25);
            this.txtCommand.TabIndex = 21;
            this.txtCommand.Text = "";
            this.txtCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbOutgoing_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(177, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "X Points";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(177, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Length Between Points";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLengthBetweenPointsX
            // 
            this.textBoxLengthBetweenPointsX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLengthBetweenPointsX.Location = new System.Drawing.Point(316, 34);
            this.textBoxLengthBetweenPointsX.Name = "textBoxLengthBetweenPointsX";
            this.textBoxLengthBetweenPointsX.Size = new System.Drawing.Size(46, 20);
            this.textBoxLengthBetweenPointsX.TabIndex = 28;
            this.textBoxLengthBetweenPointsX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(368, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "in.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbIncoming
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtbIncoming, 3);
            this.rtbIncoming.Location = new System.Drawing.Point(410, 34);
            this.rtbIncoming.Name = "rtbIncoming";
            this.rtbIncoming.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.rtbIncoming, 3);
            this.rtbIncoming.Size = new System.Drawing.Size(260, 77);
            this.rtbIncoming.TabIndex = 1;
            this.rtbIncoming.Text = "";
            this.rtbIncoming.TextChanged += new System.EventHandler(this.rtbIncoming_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(410, 117);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(58, 23);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // XlExportButton
            // 
            this.XlExportButton.Location = new System.Drawing.Point(474, 117);
            this.XlExportButton.Name = "XlExportButton";
            this.XlExportButton.Size = new System.Drawing.Size(75, 23);
            this.XlExportButton.TabIndex = 24;
            this.XlExportButton.Text = "Export";
            this.XlExportButton.UseVisualStyleBackColor = true;
            this.XlExportButton.Click += new System.EventHandler(this.XlExportButton_Click);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(3, 91);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(71, 20);
            this.btnHello.TabIndex = 22;
            this.btnHello.Text = "Send Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnPortState
            // 
            this.btnPortState.Location = new System.Drawing.Point(3, 64);
            this.btnPortState.Name = "btnPortState";
            this.btnPortState.Size = new System.Drawing.Size(71, 21);
            this.btnPortState.TabIndex = 14;
            this.btnPortState.Text = "Closed";
            this.btnPortState.UseVisualStyleBackColor = true;
            this.btnPortState.Click += new System.EventHandler(this.btnPortState_Click);
            // 
            // btnPorts
            // 
            this.btnPorts.Location = new System.Drawing.Point(3, 34);
            this.btnPorts.Name = "btnPorts";
            this.btnPorts.Size = new System.Drawing.Size(71, 23);
            this.btnPorts.TabIndex = 1;
            this.btnPorts.Text = "Ports";
            this.btnPorts.UseVisualStyleBackColor = true;
            this.btnPorts.Click += new System.EventHandler(this.btnGetSerialPorts_Click);
            // 
            // checkBoxManualSetting
            // 
            this.checkBoxManualSetting.AutoSize = true;
            this.checkBoxManualSetting.Location = new System.Drawing.Point(3, 3);
            this.checkBoxManualSetting.Name = "checkBoxManualSetting";
            this.checkBoxManualSetting.Size = new System.Drawing.Size(102, 17);
            this.checkBoxManualSetting.TabIndex = 33;
            this.checkBoxManualSetting.Text = "Manual Settings";
            this.checkBoxManualSetting.UseVisualStyleBackColor = true;
            this.checkBoxManualSetting.CheckedChanged += new System.EventHandler(this.checkBoxManualSetting_CheckedChanged);
            // 
            // comboBoxMeasurePoints
            // 
            this.comboBoxMeasurePoints.FormattingEnabled = true;
            this.comboBoxMeasurePoints.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxMeasurePoints.Location = new System.Drawing.Point(316, 3);
            this.comboBoxMeasurePoints.Name = "comboBoxMeasurePoints";
            this.comboBoxMeasurePoints.Size = new System.Drawing.Size(46, 21);
            this.comboBoxMeasurePoints.TabIndex = 34;
            this.comboBoxMeasurePoints.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeasurePoints_SelectedIndexChanged);
            // 
            // textBoxLengthBetweenPointsDegrees
            // 
            this.textBoxLengthBetweenPointsDegrees.Location = new System.Drawing.Point(316, 91);
            this.textBoxLengthBetweenPointsDegrees.Name = "textBoxLengthBetweenPointsDegrees";
            this.textBoxLengthBetweenPointsDegrees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxLengthBetweenPointsDegrees.Size = new System.Drawing.Size(46, 20);
            this.textBoxLengthBetweenPointsDegrees.TabIndex = 29;
            this.textBoxLengthBetweenPointsDegrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "°";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxRotations
            // 
            this.textBoxRotations.Location = new System.Drawing.Point(316, 64);
            this.textBoxRotations.Name = "textBoxRotations";
            this.textBoxRotations.Size = new System.Drawing.Size(46, 20);
            this.textBoxRotations.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(177, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 27);
            this.label5.TabIndex = 36;
            this.label5.Text = "Rotations";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(177, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 26);
            this.label6.TabIndex = 37;
            this.label6.Text = "Rotation Step";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 823);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gwTerm1);
            this.Controls.Add(this.gwSettings1);
            this.Controls.Add(this.gwPoll1);
            this.Controls.Add(this.gwDatRec2);
            this.Controls.Add(this.gwDatRec1);
            this.Controls.Add(this.gwComs1);
            this.Name = "Form1";
            this.Text = "Galil Widgets Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion

            public GalilWidgets.GWComs gwComs1;
            public GalilWidgets.GWDatRec gwDatRec1;
            public GalilWidgets.GWDatRec gwDatRec2;
            public GalilWidgets.GWSettings gwSettings1;
            public GalilWidgets.GWTerm gwTerm1;
            public GalilWidgets.GWPoll gwPoll1;
            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            private System.Windows.Forms.Button btnPorts;
            private System.Windows.Forms.Button btnPortState;
            private System.Windows.Forms.ComboBox cboPorts;
            private System.Windows.Forms.ComboBox cboBaudRate;
            private System.Windows.Forms.ComboBox cboDataBits;
            private System.Windows.Forms.ComboBox cboStopBits;
            private System.Windows.Forms.ComboBox cboParity;
            private System.Windows.Forms.ComboBox cboHandShaking;
            private System.Windows.Forms.RichTextBox txtCommand;
            private System.Windows.Forms.RichTextBox rtbIncoming;
            private System.Windows.Forms.Button btnHello;
            private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button XlExportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLengthBetweenPointsX;
        private System.Windows.Forms.TextBox textBoxLengthBetweenPointsDegrees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxManualSetting;
        private System.Windows.Forms.ComboBox comboBoxMeasurePoints;
        private System.Windows.Forms.TextBox textBoxRotations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

