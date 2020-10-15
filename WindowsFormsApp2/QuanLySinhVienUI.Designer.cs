namespace WindowsFormsApp2
{
    partial class QuanLySinhVienUI
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
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lsKhoa = new System.Windows.Forms.ListBox();
            this.lsLop = new System.Windows.Forms.ListBox();
            this.lsSV = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(16, 11);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(148, 20);
            this.txtMaLop.TabIndex = 0;
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(453, 9);
            this.btnThemLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(91, 19);
            this.btnThemLop.TabIndex = 1;
            this.btnThemLop.Text = "OK";
            this.btnThemLop.UseVisualStyleBackColor = true;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(182, 10);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(148, 20);
            this.txtTenLop.TabIndex = 2;
            // 
            // lsKhoa
            // 
            this.lsKhoa.FormattingEnabled = true;
            this.lsKhoa.Location = new System.Drawing.Point(16, 52);
            this.lsKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsKhoa.Name = "lsKhoa";
            this.lsKhoa.Size = new System.Drawing.Size(148, 290);
            this.lsKhoa.TabIndex = 3;
            // 
            // lsLop
            // 
            this.lsLop.FormattingEnabled = true;
            this.lsLop.Location = new System.Drawing.Point(190, 52);
            this.lsLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsLop.Name = "lsLop";
            this.lsLop.Size = new System.Drawing.Size(190, 290);
            this.lsLop.TabIndex = 4;
            // 
            // lsSV
            // 
            this.lsSV.FormattingEnabled = true;
            this.lsSV.Location = new System.Drawing.Point(406, 52);
            this.lsSV.Name = "lsSV";
            this.lsSV.Size = new System.Drawing.Size(120, 290);
            this.lsSV.TabIndex = 5;
            // 
            // QuanLySinhVienUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lsSV);
            this.Controls.Add(this.lsLop);
            this.Controls.Add(this.lsKhoa);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.txtMaLop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLySinhVienUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLySinhVienUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.ListBox lsKhoa;
        private System.Windows.Forms.ListBox lsLop;
        private System.Windows.Forms.ListBox lsSV;
    }
}