namespace WindowsFormsApp2.User_UI
{
    partial class GiaoDienUser
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
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.btnDoiMK = new Guna.UI.WinForms.GunaButton();
            this.btnDanhSach = new Guna.UI.WinForms.GunaButton();
            this.btnThongTin = new Guna.UI.WinForms.GunaButton();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = null;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(208, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(169, 69);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.AnimationHoverSpeed = 0.07F;
            this.btnDoiMK.AnimationSpeed = 0.03F;
            this.btnDoiMK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnDoiMK.BorderColor = System.Drawing.Color.Black;
            this.btnDoiMK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDoiMK.FocusedColor = System.Drawing.Color.Empty;
            this.btnDoiMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDoiMK.ForeColor = System.Drawing.Color.White;
            this.btnDoiMK.Image = null;
            this.btnDoiMK.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDoiMK.Location = new System.Drawing.Point(11, 221);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDoiMK.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDoiMK.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDoiMK.OnHoverImage = null;
            this.btnDoiMK.OnPressedColor = System.Drawing.Color.Black;
            this.btnDoiMK.Size = new System.Drawing.Size(169, 69);
            this.btnDoiMK.TabIndex = 8;
            this.btnDoiMK.Text = "Đổi Mật Khẩu";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.AnimationHoverSpeed = 0.07F;
            this.btnDanhSach.AnimationSpeed = 0.03F;
            this.btnDanhSach.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnDanhSach.BorderColor = System.Drawing.Color.Black;
            this.btnDanhSach.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDanhSach.FocusedColor = System.Drawing.Color.Empty;
            this.btnDanhSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDanhSach.ForeColor = System.Drawing.Color.White;
            this.btnDanhSach.Image = null;
            this.btnDanhSach.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDanhSach.Location = new System.Drawing.Point(208, 125);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDanhSach.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDanhSach.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDanhSach.OnHoverImage = null;
            this.btnDanhSach.OnPressedColor = System.Drawing.Color.Black;
            this.btnDanhSach.Size = new System.Drawing.Size(169, 69);
            this.btnDanhSach.TabIndex = 7;
            this.btnDanhSach.Text = "Danh Sách Sinh Viên Lớp";
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.AnimationHoverSpeed = 0.07F;
            this.btnThongTin.AnimationSpeed = 0.03F;
            this.btnThongTin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThongTin.BorderColor = System.Drawing.Color.Black;
            this.btnThongTin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThongTin.FocusedColor = System.Drawing.Color.Empty;
            this.btnThongTin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongTin.ForeColor = System.Drawing.Color.White;
            this.btnThongTin.Image = null;
            this.btnThongTin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThongTin.Location = new System.Drawing.Point(11, 125);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThongTin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThongTin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThongTin.OnHoverImage = null;
            this.btnThongTin.OnPressedColor = System.Drawing.Color.Black;
            this.btnThongTin.Size = new System.Drawing.Size(169, 69);
            this.btnThongTin.TabIndex = 6;
            this.btnThongTin.Text = "Thông Tin ";
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(365, 89);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GiaoDienUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 301);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiaoDienUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoDienUser";
            this.Load += new System.EventHandler(this.GiaoDienUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaButton btnDoiMK;
        private Guna.UI.WinForms.GunaButton btnDanhSach;
        private Guna.UI.WinForms.GunaButton btnThongTin;
        private Guna.UI.WinForms.GunaLabel lblTitle;
    }
}