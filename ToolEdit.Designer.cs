namespace Hitachi_Astemo
{
    partial class ToolEdit
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
            this.cogToolBlockEdit = new Cognex.VisionPro.ToolBlock.CogToolBlockEditV2();
            ((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // cogToolBlockEdit
            // 
            this.cogToolBlockEdit.AllowDrop = true;
            this.cogToolBlockEdit.ContextMenuCustomizer = null;
            this.cogToolBlockEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogToolBlockEdit.Location = new System.Drawing.Point(0, 0);
            this.cogToolBlockEdit.Margin = new System.Windows.Forms.Padding(2);
            this.cogToolBlockEdit.MinimumSize = new System.Drawing.Size(367, 0);
            this.cogToolBlockEdit.Name = "cogToolBlockEdit";
            this.cogToolBlockEdit.ShowNodeToolTips = true;
            this.cogToolBlockEdit.Size = new System.Drawing.Size(924, 583);
            this.cogToolBlockEdit.SuspendElectricRuns = false;
            this.cogToolBlockEdit.TabIndex = 0;
            // 
            // ToolEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.cogToolBlockEdit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ToolEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolEdit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToolEdit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 cogToolBlockEdit;
    }
}