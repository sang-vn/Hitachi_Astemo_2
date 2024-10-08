﻿namespace Hitachi_Astemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.cogVerifierControl1 = new Cognex.VisionPro.Inspection.CogVerifierControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bnEn_Vn = new System.Windows.Forms.Button();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cogRecordDisplay5 = new Cognex.VisionPro.CogRecordDisplay();
            this.cogRecordDisplay2 = new Cognex.VisionPro.CogRecordDisplay();
            this.cogRecordDisplay3 = new Cognex.VisionPro.CogRecordDisplay();
            this.cogRecordDisplay4 = new Cognex.VisionPro.CogRecordDisplay();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbPLC = new System.Windows.Forms.Label();
            this.lbCamera = new System.Windows.Forms.Label();
            this.lbLights = new System.Windows.Forms.Label();
            this.lbPLCConnected = new System.Windows.Forms.Label();
            this.lbCameraConnected = new System.Windows.Forms.Label();
            this.lbLightsConnected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.lbOkCounter = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.lbNgCounter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsChuongTrinh_Menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSetupCamera_Menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSetupPLC_Menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSetupLights_Menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogs_Menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHelps_Menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bnBegin = new System.Windows.Forms.Button();
            this.bnEnd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay4)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel26.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cogVerifierControl1
            // 
            this.cogVerifierControl1.Enabled = false;
            this.cogVerifierControl1.Location = new System.Drawing.Point(0, 0);
            this.cogVerifierControl1.Name = "cogVerifierControl1";
            this.cogVerifierControl1.Size = new System.Drawing.Size(800, 450);
            this.cogVerifierControl1.Subject = null;
            this.cogVerifierControl1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel26, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1540, 845);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.bnEn_Vn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbUser, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1283, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(254, 39);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // bnEn_Vn
            // 
            this.bnEn_Vn.BackColor = System.Drawing.Color.DodgerBlue;
            this.bnEn_Vn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnEn_Vn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnEn_Vn.Location = new System.Drawing.Point(155, 3);
            this.bnEn_Vn.Name = "bnEn_Vn";
            this.bnEn_Vn.Size = new System.Drawing.Size(96, 33);
            this.bnEn_Vn.TabIndex = 1;
            this.bnEn_Vn.Text = "en/vn";
            this.bnEn_Vn.UseVisualStyleBackColor = false;
            // 
            // cbbUser
            // 
            this.cbbUser.BackColor = System.Drawing.SystemColors.Info;
            this.cbbUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Items.AddRange(new object[] {
            "Admin",
            "Programmer",
            "Operator"});
            this.cbbUser.Location = new System.Drawing.Point(3, 5);
            this.cbbUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(146, 33);
            this.cbbUser.TabIndex = 2;
            this.cbbUser.Text = "Operator";
            this.cbbUser.SelectedIndexChanged += new System.EventHandler(this.cbbUser_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.cogRecordDisplay1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1274, 794);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(3, 3);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(1013, 788);
            this.cogRecordDisplay1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.cogRecordDisplay5, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.cogRecordDisplay2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cogRecordDisplay3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cogRecordDisplay4, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1022, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(249, 788);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // cogRecordDisplay5
            // 
            this.cogRecordDisplay5.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay5.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay5.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay5.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay5.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay5.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay5.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay5.Location = new System.Drawing.Point(3, 594);
            this.cogRecordDisplay5.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay5.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay5.Name = "cogRecordDisplay5";
            this.cogRecordDisplay5.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay5.OcxState")));
            this.cogRecordDisplay5.Size = new System.Drawing.Size(243, 191);
            this.cogRecordDisplay5.TabIndex = 5;
            // 
            // cogRecordDisplay2
            // 
            this.cogRecordDisplay2.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay2.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay2.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay2.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay2.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay2.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay2.Location = new System.Drawing.Point(3, 3);
            this.cogRecordDisplay2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay2.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay2.Name = "cogRecordDisplay2";
            this.cogRecordDisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay2.OcxState")));
            this.cogRecordDisplay2.Size = new System.Drawing.Size(243, 191);
            this.cogRecordDisplay2.TabIndex = 0;
            // 
            // cogRecordDisplay3
            // 
            this.cogRecordDisplay3.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay3.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay3.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay3.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay3.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay3.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay3.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay3.Location = new System.Drawing.Point(3, 200);
            this.cogRecordDisplay3.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay3.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay3.Name = "cogRecordDisplay3";
            this.cogRecordDisplay3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay3.OcxState")));
            this.cogRecordDisplay3.Size = new System.Drawing.Size(243, 191);
            this.cogRecordDisplay3.TabIndex = 1;
            // 
            // cogRecordDisplay4
            // 
            this.cogRecordDisplay4.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay4.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay4.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay4.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay4.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay4.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay4.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay4.Location = new System.Drawing.Point(3, 397);
            this.cogRecordDisplay4.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay4.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay4.Name = "cogRecordDisplay4";
            this.cogRecordDisplay4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay4.OcxState")));
            this.cogRecordDisplay4.Size = new System.Drawing.Size(243, 191);
            this.cogRecordDisplay4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1283, 48);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(254, 794);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(248, 162);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lbPLC, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbCamera, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbLights, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.lbPLCConnected, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbCameraConnected, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbLightsConnected, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(242, 116);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // lbPLC
            // 
            this.lbPLC.AutoSize = true;
            this.lbPLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbPLC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPLC.Location = new System.Drawing.Point(3, 3);
            this.lbPLC.Margin = new System.Windows.Forms.Padding(3);
            this.lbPLC.Name = "lbPLC";
            this.lbPLC.Size = new System.Drawing.Size(115, 32);
            this.lbPLC.TabIndex = 0;
            this.lbPLC.Text = "PLC";
            this.lbPLC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCamera
            // 
            this.lbCamera.AutoSize = true;
            this.lbCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamera.Location = new System.Drawing.Point(3, 41);
            this.lbCamera.Margin = new System.Windows.Forms.Padding(3);
            this.lbCamera.Name = "lbCamera";
            this.lbCamera.Size = new System.Drawing.Size(115, 32);
            this.lbCamera.TabIndex = 2;
            this.lbCamera.Text = "Camera";
            this.lbCamera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLights
            // 
            this.lbLights.AutoSize = true;
            this.lbLights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbLights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLights.Location = new System.Drawing.Point(3, 79);
            this.lbLights.Margin = new System.Windows.Forms.Padding(3);
            this.lbLights.Name = "lbLights";
            this.lbLights.Size = new System.Drawing.Size(115, 34);
            this.lbLights.TabIndex = 6;
            this.lbLights.Text = "Lights";
            this.lbLights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPLCConnected
            // 
            this.lbPLCConnected.AutoSize = true;
            this.lbPLCConnected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPLCConnected.ForeColor = System.Drawing.Color.Lime;
            this.lbPLCConnected.Location = new System.Drawing.Point(124, 3);
            this.lbPLCConnected.Margin = new System.Windows.Forms.Padding(3);
            this.lbPLCConnected.Name = "lbPLCConnected";
            this.lbPLCConnected.Size = new System.Drawing.Size(115, 32);
            this.lbPLCConnected.TabIndex = 1;
            this.lbPLCConnected.Text = "Đã kết nối";
            this.lbPLCConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCameraConnected
            // 
            this.lbCameraConnected.AutoSize = true;
            this.lbCameraConnected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCameraConnected.ForeColor = System.Drawing.Color.Lime;
            this.lbCameraConnected.Location = new System.Drawing.Point(124, 41);
            this.lbCameraConnected.Margin = new System.Windows.Forms.Padding(3);
            this.lbCameraConnected.Name = "lbCameraConnected";
            this.lbCameraConnected.Size = new System.Drawing.Size(115, 32);
            this.lbCameraConnected.TabIndex = 3;
            this.lbCameraConnected.Text = "Đã kết nối";
            this.lbCameraConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLightsConnected
            // 
            this.lbLightsConnected.AutoSize = true;
            this.lbLightsConnected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLightsConnected.ForeColor = System.Drawing.Color.Lime;
            this.lbLightsConnected.Location = new System.Drawing.Point(124, 79);
            this.lbLightsConnected.Margin = new System.Windows.Forms.Padding(3);
            this.lbLightsConnected.Name = "lbLightsConnected";
            this.lbLightsConnected.Size = new System.Drawing.Size(115, 34);
            this.lbLightsConnected.TabIndex = 5;
            this.lbLightsConnected.Text = "Đã kết nối";
            this.lbLightsConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRẠNG THÁI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.BurlyWood;
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel10, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel11, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.lbModel, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.pictureBox1, 0, 5);
            this.tableLayoutPanel8.Controls.Add(this.tbLog, 0, 4);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 188);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 6;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(248, 603);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.lbOkCounter, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(6, 112);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(236, 44);
            this.tableLayoutPanel10.TabIndex = 15;
            // 
            // lbOkCounter
            // 
            this.lbOkCounter.AutoSize = true;
            this.lbOkCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOkCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOkCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOkCounter.Location = new System.Drawing.Point(118, 5);
            this.lbOkCounter.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lbOkCounter.Name = "lbOkCounter";
            this.lbOkCounter.Size = new System.Drawing.Size(113, 34);
            this.lbOkCounter.TabIndex = 1;
            this.lbOkCounter.Text = "0";
            this.lbOkCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "OK";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.lbNgCounter, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(6, 165);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(236, 44);
            this.tableLayoutPanel11.TabIndex = 14;
            // 
            // lbNgCounter
            // 
            this.lbNgCounter.AutoSize = true;
            this.lbNgCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNgCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNgCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgCounter.Location = new System.Drawing.Point(118, 5);
            this.lbNgCounter.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lbNgCounter.Name = "lbNgCounter";
            this.lbNgCounter.Size = new System.Drawing.Size(113, 34);
            this.lbNgCounter.TabIndex = 1;
            this.lbNgCounter.Text = "0";
            this.lbNgCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "NG";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "KẾT QUẢ KIỂM TRA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.Location = new System.Drawing.Point(6, 56);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(236, 50);
            this.lbModel.TabIndex = 16;
            this.lbModel.Text = "HMLLOR";
            this.lbModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Hitachi_Astemo.Properties.Resources.VNAS_icon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 453);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(6, 218);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(236, 226);
            this.tbLog.TabIndex = 17;
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.ColumnCount = 4;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel26.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel26.Controls.Add(this.bnBegin, 1, 0);
            this.tableLayoutPanel26.Controls.Add(this.bnEnd, 2, 0);
            this.tableLayoutPanel26.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 1;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(1274, 39);
            this.tableLayoutPanel26.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsChuongTrinh_Menu1,
            this.tsSetupCamera_Menu1,
            this.tsSetupPLC_Menu1,
            this.tsSetupLights_Menu1,
            this.tsLogs_Menu1,
            this.tsHelps_Menu1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsChuongTrinh_Menu1
            // 
            this.tsChuongTrinh_Menu1.AutoSize = false;
            this.tsChuongTrinh_Menu1.Name = "tsChuongTrinh_Menu1";
            this.tsChuongTrinh_Menu1.Size = new System.Drawing.Size(130, 35);
            this.tsChuongTrinh_Menu1.Text = "Chương trình";
            this.tsChuongTrinh_Menu1.Click += new System.EventHandler(this.tsChuongTrinh_Menu1_Click);
            // 
            // tsSetupCamera_Menu1
            // 
            this.tsSetupCamera_Menu1.AutoSize = false;
            this.tsSetupCamera_Menu1.Name = "tsSetupCamera_Menu1";
            this.tsSetupCamera_Menu1.Size = new System.Drawing.Size(130, 35);
            this.tsSetupCamera_Menu1.Text = "Camera";
            this.tsSetupCamera_Menu1.Click += new System.EventHandler(this.tsSetupCamera_Menu1_Click);
            // 
            // tsSetupPLC_Menu1
            // 
            this.tsSetupPLC_Menu1.AutoSize = false;
            this.tsSetupPLC_Menu1.Name = "tsSetupPLC_Menu1";
            this.tsSetupPLC_Menu1.Size = new System.Drawing.Size(50, 35);
            this.tsSetupPLC_Menu1.Text = "PLC";
            this.tsSetupPLC_Menu1.Click += new System.EventHandler(this.tsSetupPLC_Menu1_Click);
            // 
            // tsSetupLights_Menu1
            // 
            this.tsSetupLights_Menu1.AutoSize = false;
            this.tsSetupLights_Menu1.Name = "tsSetupLights_Menu1";
            this.tsSetupLights_Menu1.Size = new System.Drawing.Size(90, 30);
            this.tsSetupLights_Menu1.Text = "Đèn";
            this.tsSetupLights_Menu1.Click += new System.EventHandler(this.tsSetupLights_Menu1_Click);
            // 
            // tsLogs_Menu1
            // 
            this.tsLogs_Menu1.Name = "tsLogs_Menu1";
            this.tsLogs_Menu1.Size = new System.Drawing.Size(88, 35);
            this.tsLogs_Menu1.Text = "Dữ liệu";
            // 
            // tsHelps_Menu1
            // 
            this.tsHelps_Menu1.Name = "tsHelps_Menu1";
            this.tsHelps_Menu1.Size = new System.Drawing.Size(98, 35);
            this.tsHelps_Menu1.Text = "Trợ giúp";
            // 
            // bnBegin
            // 
            this.bnBegin.BackColor = System.Drawing.Color.Blue;
            this.bnBegin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBegin.Location = new System.Drawing.Point(587, 0);
            this.bnBegin.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bnBegin.Name = "bnBegin";
            this.bnBegin.Size = new System.Drawing.Size(114, 39);
            this.bnBegin.TabIndex = 1;
            this.bnBegin.Text = "Bắt đầu";
            this.bnBegin.UseVisualStyleBackColor = false;
            this.bnBegin.Click += new System.EventHandler(this.bnBegin_Click);
            // 
            // bnEnd
            // 
            this.bnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bnEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bnEnd.Location = new System.Drawing.Point(707, 0);
            this.bnEnd.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bnEnd.Name = "bnEnd";
            this.bnEnd.Size = new System.Drawing.Size(114, 39);
            this.bnEnd.TabIndex = 2;
            this.bnEnd.Text = "Kết thúc";
            this.bnEnd.UseVisualStyleBackColor = false;
            this.bnEnd.Click += new System.EventHandler(this.bnEnd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(827, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ảnh NG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG KIỂM TRA NGOẠI QUAN HITACHI ASTEMO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay4)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ServiceProcess.ServiceController serviceController1;
        private Cognex.VisionPro.Inspection.CogVerifierControl cogVerifierControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bnEn_Vn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lbPLC;
        private System.Windows.Forms.Label lbLightsConnected;
        private System.Windows.Forms.Label lbCameraConnected;
        private System.Windows.Forms.Label lbCamera;
        private System.Windows.Forms.Label lbPLCConnected;
        private System.Windows.Forms.Label lbLights;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsChuongTrinh_Menu1;
        private System.Windows.Forms.ToolStripMenuItem tsSetupCamera_Menu1;
        private System.Windows.Forms.ToolStripMenuItem tsSetupPLC_Menu1;
        private System.Windows.Forms.ToolStripMenuItem tsSetupLights_Menu1;
        private System.Windows.Forms.ToolStripMenuItem tsLogs_Menu1;
        private System.Windows.Forms.ToolStripMenuItem tsHelps_Menu1;
        private System.Windows.Forms.Button bnBegin;
        private System.Windows.Forms.Button bnEnd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label lbOkCounter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label lbNgCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay5;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay2;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay3;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay4;
    }
}

