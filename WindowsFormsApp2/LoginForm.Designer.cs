﻿using System.Drawing;

namespace WindowsFormsApp2
{
    partial class LoginForm
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblQuenMatKhau = new System.Windows.Forms.Label();
            this.txtPass = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbHienMatKhau = new Guna.UI.WinForms.GunaCheckBox();
            this.btnDangNhap = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 45;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.students;
            this.gunaPictureBox1.Location = new System.Drawing.Point(62, 75);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(345, 313);
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(62)))), ((int)(((byte)(201)))));
            this.gunaLabel1.Location = new System.Drawing.Point(34, 16);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(83, 37);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Login";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(110, 16);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 37);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Account";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnDangNhap);
            this.gunaShadowPanel1.Controls.Add(this.ckbHienMatKhau);
            this.gunaShadowPanel1.Controls.Add(this.lblQuenMatKhau);
            this.gunaShadowPanel1.Controls.Add(this.txtPass);
            this.gunaShadowPanel1.Controls.Add(this.label2);
            this.gunaShadowPanel1.Controls.Add(this.txtID);
            this.gunaShadowPanel1.Controls.Add(this.label1);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(470, 75);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(244, 313);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // lblQuenMatKhau
            // 
            this.lblQuenMatKhau.AutoSize = true;
            this.lblQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(95)))), ((int)(((byte)(223)))));
            this.lblQuenMatKhau.Location = new System.Drawing.Point(111, 197);
            this.lblQuenMatKhau.Name = "lblQuenMatKhau";
            this.lblQuenMatKhau.Size = new System.Drawing.Size(120, 20);
            this.lblQuenMatKhau.TabIndex = 6;
            this.lblQuenMatKhau.Text = "Quên Mật Khẩu";
            this.lblQuenMatKhau.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.lblQuenMatKhau.MouseLeave += new System.EventHandler(this.lblQuenMatKhau_MouseLeave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPass.Location = new System.Drawing.Point(39, 152);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(189, 32);
            this.txtPass.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.LineColor = System.Drawing.Color.Gainsboro;
            this.txtID.Location = new System.Drawing.Point(39, 79);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(189, 32);
            this.txtID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // ckbHienMatKhau
            // 
            this.ckbHienMatKhau.BaseColor = System.Drawing.Color.White;
            this.ckbHienMatKhau.CheckedOffColor = System.Drawing.Color.Gray;
            this.ckbHienMatKhau.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ckbHienMatKhau.FillColor = System.Drawing.Color.White;
            this.ckbHienMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHienMatKhau.Location = new System.Drawing.Point(20, 228);
            this.ckbHienMatKhau.Name = "ckbHienMatKhau";
            this.ckbHienMatKhau.Size = new System.Drawing.Size(211, 22);
            this.ckbHienMatKhau.TabIndex = 7;
            this.ckbHienMatKhau.Text = "Show Mật Khẩu";
            this.ckbHienMatKhau.CheckedChanged += new System.EventHandler(this.ckbHienMatKhau_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AnimationHoverSpeed = 0.07F;
            this.btnDangNhap.AnimationSpeed = 0.03F;
            this.btnDangNhap.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnDangNhap.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnDangNhap.BorderColor = System.Drawing.Color.Black;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDangNhap.FocusedColor = System.Drawing.Color.Empty;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Image = null;
            this.btnDangNhap.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDangNhap.Location = new System.Drawing.Point(20, 257);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnDangNhap.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnDangNhap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDangNhap.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDangNhap.OnHoverImage = null;
            this.btnDangNhap.OnPressedColor = System.Drawing.Color.Black;
            this.btnDangNhap.Size = new System.Drawing.Size(208, 42);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDangNhap.MouseEnter += new System.EventHandler(this.btnDangNhap_MouseEnter);
            this.btnDangNhap.MouseLeave += new System.EventHandler(this.btnDangNhap_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txtID;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuenMatKhau;
        private Guna.UI.WinForms.GunaCheckBox ckbHienMatKhau;
        private Guna.UI.WinForms.GunaGradientButton btnDangNhap;
    }
}

