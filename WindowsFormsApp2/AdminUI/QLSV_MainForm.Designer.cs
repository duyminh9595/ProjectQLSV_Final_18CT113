﻿namespace WindowsFormsApp2
{
    partial class QLSV_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLSV_MainForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pnData = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnMatKhau = new System.Windows.Forms.Button();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnMKGV = new System.Windows.Forms.Button();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 45;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(220, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(488, 25);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Mèo Con Ngok Ngek";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // pnData
            // 
            this.pnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnData.Location = new System.Drawing.Point(179, 41);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(791, 696);
            this.pnData.TabIndex = 2;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(715, 13);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Thoat";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Location = new System.Drawing.Point(57, 13);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(75, 23);
            this.btnSinhVien.TabIndex = 5;
            this.btnSinhVien.Text = "SinhVien";
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.btnMKGV);
            this.gunaGradientPanel1.Controls.Add(this.btnMatKhau);
            this.gunaGradientPanel1.Controls.Add(this.btnThemLop);
            this.gunaGradientPanel1.Controls.Add(this.btnGiaoVien);
            this.gunaGradientPanel1.Controls.Add(this.btnLop);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(26, 41);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(133, 696);
            this.gunaGradientPanel1.TabIndex = 3;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // btnMatKhau
            // 
            this.btnMatKhau.Location = new System.Drawing.Point(15, 355);
            this.btnMatKhau.Name = "btnMatKhau";
            this.btnMatKhau.Size = new System.Drawing.Size(102, 84);
            this.btnMatKhau.TabIndex = 9;
            this.btnMatKhau.Text = "Đổi Mật Khẩu";
            this.btnMatKhau.UseVisualStyleBackColor = true;
            this.btnMatKhau.Click += new System.EventHandler(this.btnMatKhau_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(15, 253);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(102, 84);
            this.btnThemLop.TabIndex = 8;
            this.btnThemLop.Text = "Thêm Lớp";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Location = new System.Drawing.Point(15, 140);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(102, 84);
            this.btnGiaoVien.TabIndex = 7;
            this.btnGiaoVien.Text = "Giáo Viên";
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnLop
            // 
            this.btnLop.Location = new System.Drawing.Point(15, 26);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(102, 84);
            this.btnLop.TabIndex = 6;
            this.btnLop.Text = "In Danh Sach Lop";
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnMKGV
            // 
            this.btnMKGV.Location = new System.Drawing.Point(15, 445);
            this.btnMKGV.Name = "btnMKGV";
            this.btnMKGV.Size = new System.Drawing.Size(102, 84);
            this.btnMKGV.TabIndex = 10;
            this.btnMKGV.Text = "Đổi Mật Khẩu Giáo Viên";
            this.btnMKGV.UseVisualStyleBackColor = true;
            this.btnMKGV.Click += new System.EventHandler(this.btnMKGV_Click);
            // 
            // QLSV_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1000, 749);
            this.Controls.Add(this.btnSinhVien);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.gunaLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QLSV_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLSV_MainForm";
            this.Load += new System.EventHandler(this.QLSV_MainForm_Load_1);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel pnData;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Button btnMatKhau;
        private System.Windows.Forms.Button btnMKGV;
    }
}