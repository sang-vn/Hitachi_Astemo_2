namespace Hitachi_Astemo
{
    partial class EditProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbListPrograms = new System.Windows.Forms.TextBox();
            this.bnEdit = new System.Windows.Forms.Button();
            this.bnAdd = new System.Windows.Forms.Button();
            this.bnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(83, 6);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(284, 22);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // tbListPrograms
            // 
            this.tbListPrograms.Location = new System.Drawing.Point(15, 33);
            this.tbListPrograms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbListPrograms.Multiline = true;
            this.tbListPrograms.Name = "tbListPrograms";
            this.tbListPrograms.Size = new System.Drawing.Size(352, 212);
            this.tbListPrograms.TabIndex = 2;
            // 
            // bnEdit
            // 
            this.bnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.bnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bnEdit.Location = new System.Drawing.Point(43, 252);
            this.bnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(77, 30);
            this.bnEdit.TabIndex = 3;
            this.bnEdit.Text = "Sửa";
            this.bnEdit.UseVisualStyleBackColor = false;
            this.bnEdit.Click += new System.EventHandler(this.bnEdit_Click);
            // 
            // bnAdd
            // 
            this.bnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.bnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bnAdd.Location = new System.Drawing.Point(152, 252);
            this.bnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(77, 30);
            this.bnAdd.TabIndex = 4;
            this.bnAdd.Text = "Thêm";
            this.bnAdd.UseVisualStyleBackColor = false;
            // 
            // bnRemove
            // 
            this.bnRemove.BackColor = System.Drawing.Color.DodgerBlue;
            this.bnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bnRemove.Location = new System.Drawing.Point(261, 252);
            this.bnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnRemove.Name = "bnRemove";
            this.bnRemove.Size = new System.Drawing.Size(77, 30);
            this.bnRemove.TabIndex = 5;
            this.bnRemove.Text = "Xóa";
            this.bnRemove.UseVisualStyleBackColor = false;
            // 
            // EditProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 288);
            this.Controls.Add(this.bnRemove);
            this.Controls.Add(this.bnAdd);
            this.Controls.Add(this.bnEdit);
            this.Controls.Add(this.tbListPrograms);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(380, 300);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programs";
            this.Load += new System.EventHandler(this.Programs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbListPrograms;
        private System.Windows.Forms.Button bnEdit;
        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.Button bnRemove;
    }
}