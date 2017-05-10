namespace GloveServerNET
{
    partial class Main
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
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbView = new System.Windows.Forms.GroupBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.cbLattice = new System.Windows.Forms.CheckBox();
            this.cbAutoRot = new System.Windows.Forms.CheckBox();
            this.cbModels = new System.Windows.Forms.ComboBox();
            this.cbCamModes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.tbGloveStatus = new System.Windows.Forms.TextBox();
            this.tbAngles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFingers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCam = new System.Windows.Forms.GroupBox();
            this.cbCam = new System.Windows.Forms.ComboBox();
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.btnStartCam = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMatrix = new System.Windows.Forms.TextBox();
            this.gbServer.SuspendLayout();
            this.gbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.gbCam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbServer
            // 
            this.gbServer.BackColor = System.Drawing.Color.White;
            this.gbServer.Controls.Add(this.tbPort);
            this.gbServer.Controls.Add(this.tbIP);
            this.gbServer.Controls.Add(this.btnStop);
            this.gbServer.Controls.Add(this.btnStart);
            this.gbServer.Controls.Add(this.label2);
            this.gbServer.Controls.Add(this.label1);
            this.gbServer.Location = new System.Drawing.Point(300, 12);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(231, 73);
            this.gbServer.TabIndex = 0;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "Server:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(41, 42);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(103, 20);
            this.tbPort.TabIndex = 5;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(41, 13);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(103, 20);
            this.tbIP.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(150, 41);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(150, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // gbView
            // 
            this.gbView.BackColor = System.Drawing.Color.White;
            this.gbView.Controls.Add(this.trackBar);
            this.gbView.Controls.Add(this.cbLattice);
            this.gbView.Controls.Add(this.cbAutoRot);
            this.gbView.Controls.Add(this.cbModels);
            this.gbView.Controls.Add(this.cbCamModes);
            this.gbView.Controls.Add(this.label4);
            this.gbView.Controls.Add(this.label3);
            this.gbView.Location = new System.Drawing.Point(300, 91);
            this.gbView.Name = "gbView";
            this.gbView.Size = new System.Drawing.Size(231, 148);
            this.gbView.TabIndex = 1;
            this.gbView.TabStop = false;
            this.gbView.Text = "View:";
            // 
            // trackBar
            // 
            this.trackBar.LargeChange = 2;
            this.trackBar.Location = new System.Drawing.Point(9, 92);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(216, 45);
            this.trackBar.TabIndex = 6;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cbLattice
            // 
            this.cbLattice.AutoSize = true;
            this.cbLattice.Checked = true;
            this.cbLattice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLattice.Location = new System.Drawing.Point(9, 69);
            this.cbLattice.Name = "cbLattice";
            this.cbLattice.Size = new System.Drawing.Size(58, 17);
            this.cbLattice.TabIndex = 5;
            this.cbLattice.Text = "Lattice";
            this.cbLattice.UseVisualStyleBackColor = true;
            this.cbLattice.CheckedChanged += new System.EventHandler(this.cbLattice_CheckedChanged);
            // 
            // cbAutoRot
            // 
            this.cbAutoRot.AutoSize = true;
            this.cbAutoRot.Location = new System.Drawing.Point(139, 69);
            this.cbAutoRot.Name = "cbAutoRot";
            this.cbAutoRot.Size = new System.Drawing.Size(86, 17);
            this.cbAutoRot.TabIndex = 4;
            this.cbAutoRot.Text = "Auto-rotation";
            this.cbAutoRot.UseVisualStyleBackColor = true;
            this.cbAutoRot.CheckedChanged += new System.EventHandler(this.cbAutoRot_CheckedChanged);
            // 
            // cbModels
            // 
            this.cbModels.FormattingEnabled = true;
            this.cbModels.Items.AddRange(new object[] {
            "earth.j3o",
            "glove.j3o",
            "StatueOfLiberty.j3o",
            "CocaCola.j3o",
            "Heart.j3o",
            "coin.j3o",
            "moon.j3o"});
            this.cbModels.Location = new System.Drawing.Point(81, 12);
            this.cbModels.Name = "cbModels";
            this.cbModels.Size = new System.Drawing.Size(144, 21);
            this.cbModels.TabIndex = 3;
            // 
            // cbCamModes
            // 
            this.cbCamModes.FormattingEnabled = true;
            this.cbCamModes.Items.AddRange(new object[] {
            "1-side mode",
            "4-sides mode"});
            this.cbCamModes.Location = new System.Drawing.Point(81, 42);
            this.cbCamModes.Name = "cbCamModes";
            this.cbCamModes.Size = new System.Drawing.Size(144, 21);
            this.cbCamModes.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cams mode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model:";
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.Color.White;
            this.gbStatus.Controls.Add(this.tbGloveStatus);
            this.gbStatus.Controls.Add(this.tbAngles);
            this.gbStatus.Controls.Add(this.label6);
            this.gbStatus.Controls.Add(this.tbFingers);
            this.gbStatus.Controls.Add(this.label5);
            this.gbStatus.Location = new System.Drawing.Point(12, 249);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(519, 45);
            this.gbStatus.TabIndex = 2;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Glove status";
            // 
            // tbGloveStatus
            // 
            this.tbGloveStatus.Location = new System.Drawing.Point(9, 13);
            this.tbGloveStatus.Name = "tbGloveStatus";
            this.tbGloveStatus.ReadOnly = true;
            this.tbGloveStatus.Size = new System.Drawing.Size(234, 20);
            this.tbGloveStatus.TabIndex = 5;
            // 
            // tbAngles
            // 
            this.tbAngles.Location = new System.Drawing.Point(446, 13);
            this.tbAngles.Name = "tbAngles";
            this.tbAngles.ReadOnly = true;
            this.tbAngles.Size = new System.Drawing.Size(67, 20);
            this.tbAngles.TabIndex = 3;
            this.tbAngles.Text = "(3.14, 3.14)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "(H, V):";
            // 
            // tbFingers
            // 
            this.tbFingers.Location = new System.Drawing.Point(299, 13);
            this.tbFingers.Name = "tbFingers";
            this.tbFingers.ReadOnly = true;
            this.tbFingers.Size = new System.Drawing.Size(98, 20);
            this.tbFingers.TabIndex = 1;
            this.tbFingers.Text = "0.5-0.5-0.5-0.5-0.5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fingers:";
            // 
            // gbCam
            // 
            this.gbCam.BackColor = System.Drawing.Color.White;
            this.gbCam.Controls.Add(this.cbCam);
            this.gbCam.Controls.Add(this.pbVideo);
            this.gbCam.Controls.Add(this.btnStartCam);
            this.gbCam.Controls.Add(this.label7);
            this.gbCam.Location = new System.Drawing.Point(12, 12);
            this.gbCam.Name = "gbCam";
            this.gbCam.Size = new System.Drawing.Size(282, 227);
            this.gbCam.TabIndex = 3;
            this.gbCam.TabStop = false;
            this.gbCam.Text = "Camera:";
            // 
            // cbCam
            // 
            this.cbCam.FormattingEnabled = true;
            this.cbCam.Location = new System.Drawing.Point(43, 12);
            this.cbCam.Name = "cbCam";
            this.cbCam.Size = new System.Drawing.Size(146, 21);
            this.cbCam.TabIndex = 4;
            // 
            // pbVideo
            // 
            this.pbVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVideo.Location = new System.Drawing.Point(6, 39);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(264, 177);
            this.pbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVideo.TabIndex = 3;
            this.pbVideo.TabStop = false;
            // 
            // btnStartCam
            // 
            this.btnStartCam.Location = new System.Drawing.Point(195, 11);
            this.btnStartCam.Name = "btnStartCam";
            this.btnStartCam.Size = new System.Drawing.Size(75, 23);
            this.btnStartCam.TabIndex = 2;
            this.btnStartCam.Text = "Start Cam";
            this.btnStartCam.UseVisualStyleBackColor = true;
            this.btnStartCam.Click += new System.EventHandler(this.btnStartCam_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cam:";
            // 
            // tbMatrix
            // 
            this.tbMatrix.Location = new System.Drawing.Point(537, 12);
            this.tbMatrix.Multiline = true;
            this.tbMatrix.Name = "tbMatrix";
            this.tbMatrix.Size = new System.Drawing.Size(140, 282);
            this.tbMatrix.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 300);
            this.Controls.Add(this.tbMatrix);
            this.Controls.Add(this.gbCam);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbView);
            this.Controls.Add(this.gbServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "Glove Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseForm);
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.gbView.ResumeLayout(false);
            this.gbView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbCam.ResumeLayout(false);
            this.gbCam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbView;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.CheckBox cbLattice;
        private System.Windows.Forms.CheckBox cbAutoRot;
        private System.Windows.Forms.ComboBox cbModels;
        private System.Windows.Forms.ComboBox cbCamModes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.TextBox tbAngles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFingers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGloveStatus;
        private System.Windows.Forms.GroupBox gbCam;
        private System.Windows.Forms.Button btnStartCam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbVideo;
        private System.Windows.Forms.ComboBox cbCam;
        private System.Windows.Forms.TextBox tbMatrix;
    }
}

