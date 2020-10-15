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
            this.SuspendLayout();
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(22, 13);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(196, 22);
            this.txtMaLop.TabIndex = 0;
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(604, 11);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(121, 23);
            this.btnThemLop.TabIndex = 1;
            this.btnThemLop.Text = "OK";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(242, 12);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(196, 22);
            this.txtTenLop.TabIndex = 2;
            // 
            // lsKhoa
            // 
            this.lsKhoa.FormattingEnabled = true;
            this.lsKhoa.ItemHeight = 16;
            this.lsKhoa.Location = new System.Drawing.Point(22, 64);
            this.lsKhoa.Name = "lsKhoa";
            this.lsKhoa.Size = new System.Drawing.Size(196, 356);
            this.lsKhoa.TabIndex = 3;
            this.lsKhoa.SelectedIndexChanged += new System.EventHandler(this.lsKhoa_SelectedIndexChanged);
            // 
            // lsLop
            // 
            this.lsLop.FormattingEnabled = true;
            this.lsLop.ItemHeight = 16;
            this.lsLop.Location = new System.Drawing.Point(253, 64);
            this.lsLop.Name = "lsLop";
            this.lsLop.Size = new System.Drawing.Size(252, 356);
            this.lsLop.TabIndex = 4;
            // 
            // QuanLySinhVienUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsLop);
            this.Controls.Add(this.lsKhoa);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.txtMaLop);
            this.Name = "QuanLySinhVienUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLySinhVienUI";
            this.Load += new System.EventHandler(this.QuanLySinhVienUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.ListBox lsKhoa;
        private System.Windows.Forms.ListBox lsLop;
    }
}