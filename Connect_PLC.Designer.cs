namespace Hitachi_Astemo
{
    partial class Connect_PLC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect_PLC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIpAddress = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.bnPing = new System.Windows.Forms.Button();
            this.bnConnect = new System.Windows.Forms.Button();
            this.lbNotice = new System.Windows.Forms.Label();
            this.tbReceivedData = new System.Windows.Forms.TextBox();
            this.tbSentData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.bnWriteResultNG3 = new System.Windows.Forms.Button();
            this.bnWriteResultNG2 = new System.Windows.Forms.Button();
            this.bnHeartBits = new System.Windows.Forms.Button();
            this.bnReadModel = new System.Windows.Forms.Button();
            this.bnWriteResultNG1 = new System.Windows.Forms.Button();
            this.bnWriteResultOK = new System.Windows.Forms.Button();
            this.bnWriteAcqNG = new System.Windows.Forms.Button();
            this.bnWriteAcqOK = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bnReadTrigger = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbInvert = new System.Windows.Forms.CheckBox();
            this.bnSave = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // tbIpAddress
            // 
            this.tbIpAddress.Location = new System.Drawing.Point(104, 10);
            this.tbIpAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.ReadOnly = true;
            this.tbIpAddress.Size = new System.Drawing.Size(99, 22);
            this.tbIpAddress.TabIndex = 2;
            this.tbIpAddress.Text = "192.168.1.100";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(104, 38);
            this.tbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPort.Name = "tbPort";
            this.tbPort.ReadOnly = true;
            this.tbPort.Size = new System.Drawing.Size(99, 22);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "3000";
            // 
            // bnPing
            // 
            this.bnPing.Location = new System.Drawing.Point(19, 71);
            this.bnPing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnPing.Name = "bnPing";
            this.bnPing.Size = new System.Drawing.Size(81, 30);
            this.bnPing.TabIndex = 4;
            this.bnPing.Text = "Ping";
            this.bnPing.UseVisualStyleBackColor = true;
            // 
            // bnConnect
            // 
            this.bnConnect.Location = new System.Drawing.Point(104, 71);
            this.bnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnConnect.Name = "bnConnect";
            this.bnConnect.Size = new System.Drawing.Size(99, 30);
            this.bnConnect.TabIndex = 5;
            this.bnConnect.Text = "Connect";
            this.bnConnect.UseVisualStyleBackColor = true;
            this.bnConnect.Click += new System.EventHandler(this.bnConnect_Click);
            // 
            // lbNotice
            // 
            this.lbNotice.BackColor = System.Drawing.Color.Red;
            this.lbNotice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbNotice.Location = new System.Drawing.Point(19, 110);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(185, 44);
            this.lbNotice.TabIndex = 7;
            this.lbNotice.Text = "Disconnected";
            this.lbNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbReceivedData
            // 
            this.tbReceivedData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbReceivedData.Location = new System.Drawing.Point(235, 33);
            this.tbReceivedData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReceivedData.Multiline = true;
            this.tbReceivedData.Name = "tbReceivedData";
            this.tbReceivedData.ReadOnly = true;
            this.tbReceivedData.Size = new System.Drawing.Size(423, 120);
            this.tbReceivedData.TabIndex = 8;
            // 
            // tbSentData
            // 
            this.tbSentData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSentData.Location = new System.Drawing.Point(235, 183);
            this.tbSentData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSentData.Multiline = true;
            this.tbSentData.Name = "tbSentData";
            this.tbSentData.ReadOnly = true;
            this.tbSentData.Size = new System.Drawing.Size(423, 120);
            this.tbSentData.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Received Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sent Data";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.bnWriteResultNG3);
            this.GroupBox1.Controls.Add(this.bnWriteResultNG2);
            this.GroupBox1.Controls.Add(this.bnHeartBits);
            this.GroupBox1.Controls.Add(this.bnReadModel);
            this.GroupBox1.Controls.Add(this.bnWriteResultNG1);
            this.GroupBox1.Controls.Add(this.bnWriteResultOK);
            this.GroupBox1.Controls.Add(this.bnWriteAcqNG);
            this.GroupBox1.Controls.Add(this.bnWriteAcqOK);
            this.GroupBox1.Controls.Add(this.label12);
            this.GroupBox1.Controls.Add(this.label11);
            this.GroupBox1.Controls.Add(this.label10);
            this.GroupBox1.Controls.Add(this.label9);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.bnReadTrigger);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GroupBox1.Location = new System.Drawing.Point(19, 318);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox1.Size = new System.Drawing.Size(644, 178);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Test Data";
            // 
            // bnWriteResultNG3
            // 
            this.bnWriteResultNG3.AccessibleDescription = "";
            this.bnWriteResultNG3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnWriteResultNG3.Location = new System.Drawing.Point(484, 89);
            this.bnWriteResultNG3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnWriteResultNG3.Name = "bnWriteResultNG3";
            this.bnWriteResultNG3.Size = new System.Drawing.Size(75, 25);
            this.bnWriteResultNG3.TabIndex = 24;
            this.bnWriteResultNG3.Text = "M2032";
            this.bnWriteResultNG3.UseVisualStyleBackColor = true;
            this.bnWriteResultNG3.Click += new System.EventHandler(this.bnWriteResultNG3_Click);
            // 
            // bnWriteResultNG2
            // 
            this.bnWriteResultNG2.AccessibleDescription = "";
            this.bnWriteResultNG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnWriteResultNG2.Location = new System.Drawing.Point(397, 89);
            this.bnWriteResultNG2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnWriteResultNG2.Name = "bnWriteResultNG2";
            this.bnWriteResultNG2.Size = new System.Drawing.Size(75, 25);
            this.bnWriteResultNG2.TabIndex = 23;
            this.bnWriteResultNG2.Text = "M2031";
            this.bnWriteResultNG2.UseVisualStyleBackColor = true;
            this.bnWriteResultNG2.Click += new System.EventHandler(this.bnWriteResultNG2_Click);
            // 
            // bnHeartBits
            // 
            this.bnHeartBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnHeartBits.Location = new System.Drawing.Point(213, 144);
            this.bnHeartBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnHeartBits.Name = "bnHeartBits";
            this.bnHeartBits.Size = new System.Drawing.Size(75, 25);
            this.bnHeartBits.TabIndex = 22;
            this.bnHeartBits.Text = "M2040";
            this.bnHeartBits.UseVisualStyleBackColor = true;
            this.bnHeartBits.Click += new System.EventHandler(this.bnHeartBits_Click);
            // 
            // bnReadModel
            // 
            this.bnReadModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnReadModel.Location = new System.Drawing.Point(213, 116);
            this.bnReadModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnReadModel.Name = "bnReadModel";
            this.bnReadModel.Size = new System.Drawing.Size(75, 25);
            this.bnReadModel.TabIndex = 21;
            this.bnReadModel.Text = "D1000";
            this.bnReadModel.UseVisualStyleBackColor = true;
            this.bnReadModel.Click += new System.EventHandler(this.bnReadModel_Click);
            // 
            // bnWriteResultNG1
            // 
            this.bnWriteResultNG1.AccessibleDescription = "";
            this.bnWriteResultNG1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnWriteResultNG1.Location = new System.Drawing.Point(304, 89);
            this.bnWriteResultNG1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnWriteResultNG1.Name = "bnWriteResultNG1";
            this.bnWriteResultNG1.Size = new System.Drawing.Size(75, 25);
            this.bnWriteResultNG1.TabIndex = 20;
            this.bnWriteResultNG1.Text = "M2030";
            this.bnWriteResultNG1.UseVisualStyleBackColor = true;
            this.bnWriteResultNG1.Click += new System.EventHandler(this.bnWriteResultNG1_Click);
            // 
            // bnWriteResultOK
            // 
            this.bnWriteResultOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnWriteResultOK.Location = new System.Drawing.Point(213, 89);
            this.bnWriteResultOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnWriteResultOK.Name = "bnWriteResultOK";
            this.bnWriteResultOK.Size = new System.Drawing.Size(75, 25);
            this.bnWriteResultOK.TabIndex = 19;
            this.bnWriteResultOK.Text = "M2020";
            this.bnWriteResultOK.UseVisualStyleBackColor = true;
            this.bnWriteResultOK.Click += new System.EventHandler(this.bnWriteResultOK_Click);
            // 
            // bnWriteAcqNG
            // 
            this.bnWriteAcqNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnWriteAcqNG.Location = new System.Drawing.Point(304, 60);
            this.bnWriteAcqNG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnWriteAcqNG.Name = "bnWriteAcqNG";
            this.bnWriteAcqNG.Size = new System.Drawing.Size(75, 25);
            this.bnWriteAcqNG.TabIndex = 16;
            this.bnWriteAcqNG.Text = "M2011";
            this.bnWriteAcqNG.UseVisualStyleBackColor = true;
            this.bnWriteAcqNG.Click += new System.EventHandler(this.bnWriteAcqNG_Click);
            // 
            // bnWriteAcqOK
            // 
            this.bnWriteAcqOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnWriteAcqOK.Location = new System.Drawing.Point(213, 60);
            this.bnWriteAcqOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnWriteAcqOK.Name = "bnWriteAcqOK";
            this.bnWriteAcqOK.Size = new System.Drawing.Size(75, 25);
            this.bnWriteAcqOK.TabIndex = 15;
            this.bnWriteAcqOK.Text = "M2010";
            this.bnWriteAcqOK.UseVisualStyleBackColor = true;
            this.bnWriteAcqOK.Click += new System.EventHandler(this.bnWriteAcqOK_Click);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Heart Bits";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Read Model";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Write Vision Result";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Write Acq OK/NG";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Read Trigger";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnReadTrigger
            // 
            this.bnReadTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnReadTrigger.Location = new System.Drawing.Point(213, 32);
            this.bnReadTrigger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnReadTrigger.Name = "bnReadTrigger";
            this.bnReadTrigger.Size = new System.Drawing.Size(75, 25);
            this.bnReadTrigger.TabIndex = 0;
            this.bnReadTrigger.Text = "M2001";
            this.bnReadTrigger.UseVisualStyleBackColor = true;
            this.bnReadTrigger.Click += new System.EventHandler(this.bnReadTrigger_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbInvert);
            this.groupBox2.Location = new System.Drawing.Point(19, 183);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(185, 120);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "R/W";
            // 
            // cbInvert
            // 
            this.cbInvert.AutoSize = true;
            this.cbInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbInvert.Location = new System.Drawing.Point(57, 45);
            this.cbInvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbInvert.Name = "cbInvert";
            this.cbInvert.Size = new System.Drawing.Size(72, 24);
            this.cbInvert.TabIndex = 6;
            this.cbInvert.Text = "Invert";
            this.cbInvert.UseVisualStyleBackColor = true;
            // 
            // bnSave
            // 
            this.bnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bnSave.Location = new System.Drawing.Point(21, 502);
            this.bnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(99, 30);
            this.bnSave.TabIndex = 15;
            this.bnSave.Text = "SAVE";
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // Connect_PLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(669, 539);
            this.Controls.Add(this.bnSave);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSentData);
            this.Controls.Add(this.tbReceivedData);
            this.Controls.Add(this.lbNotice);
            this.Controls.Add(this.bnConnect);
            this.Controls.Add(this.bnPing);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIpAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Connect_PLC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect_PLC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Connect_PLC_FormClosing);
            this.Load += new System.EventHandler(this.Connect_PLC_Load);
            this.GroupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbIpAddress;
        public System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button bnPing;
        private System.Windows.Forms.Button bnConnect;
        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.TextBox tbReceivedData;
        private System.Windows.Forms.TextBox tbSentData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbInvert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bnReadTrigger;
        private System.Windows.Forms.Button bnHeartBits;
        private System.Windows.Forms.Button bnReadModel;
        private System.Windows.Forms.Button bnWriteResultNG1;
        private System.Windows.Forms.Button bnWriteResultOK;
        private System.Windows.Forms.Button bnWriteAcqOK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bnSave;
        private System.Windows.Forms.Button bnWriteAcqNG;
        private System.Windows.Forms.Button bnWriteResultNG3;
        private System.Windows.Forms.Button bnWriteResultNG2;
    }
}