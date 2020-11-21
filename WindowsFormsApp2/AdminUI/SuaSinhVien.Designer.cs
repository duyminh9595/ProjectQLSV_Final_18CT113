namespace WindowsFormsApp2.AdminUI
{
    partial class SuaSinhVien
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnThoat = new Guna.UI.WinForms.GunaGradientButton();
            this.btnThem = new Guna.UI.WinForms.GunaGradientButton();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.cmbGioiTinh = new Guna.UI.WinForms.GunaComboBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pickDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMK = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // btnThoat
            // 
            this.btnThoat.AnimationHoverSpeed = 0.07F;
            this.btnThoat.AnimationSpeed = 0.03F;
            this.btnThoat.BaseColor1 = System.Drawing.Color.Red;
            this.btnThoat.BaseColor2 = System.Drawing.Color.Red;
            this.btnThoat.BorderColor = System.Drawing.Color.Red;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.FocusedColor = System.Drawing.Color.Empty;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = null;
            this.btnThoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThoat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThoat.Location = new System.Drawing.Point(261, 558);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor1 = System.Drawing.Color.Black;
            this.btnThoat.OnHoverBaseColor2 = System.Drawing.Color.Black;
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Size = new System.Drawing.Size(136, 42);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnThem.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = null;
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(120, 558);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnThem.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Size = new System.Drawing.Size(135, 42);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "OK";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblMSSV
            // 
            this.lblMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(12, 16);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(383, 44);
            this.lblMSSV.TabIndex = 28;
            this.lblMSSV.Tag = "";
            this.lblMSSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cmbGioiTinh.BaseColor = System.Drawing.Color.White;
            this.cmbGioiTinh.BorderColor = System.Drawing.Color.Silver;
            this.cmbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FocusedColor = System.Drawing.Color.Empty;
            this.cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(120, 367);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbGioiTinh.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbGioiTinh.Size = new System.Drawing.Size(275, 34);
            this.cmbGioiTinh.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(120, 421);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(275, 44);
            this.txtEmail.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 44);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 44);
            this.label5.TabIndex = 24;
            this.label5.Text = "Giới Tính";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pickDate
            // 
            this.pickDate.BaseColor = System.Drawing.Color.White;
            this.pickDate.BorderColor = System.Drawing.Color.Silver;
            this.pickDate.CustomFormat = null;
            this.pickDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.pickDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pickDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDate.ForeColor = System.Drawing.Color.Black;
            this.pickDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickDate.Location = new System.Drawing.Point(120, 297);
            this.pickDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.pickDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.pickDate.Name = "pickDate";
            this.pickDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.pickDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pickDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pickDate.OnPressedColor = System.Drawing.Color.Black;
            this.pickDate.Size = new System.Drawing.Size(275, 44);
            this.pickDate.TabIndex = 23;
            this.pickDate.Text = "16/10/2020";
            this.pickDate.Value = new System.DateTime(2020, 10, 16, 18, 53, 41, 194);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 44);
            this.label4.TabIndex = 22;
            this.label4.Text = "Năm Sinh";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSDT
            // 
            this.txtSDT.BaseColor = System.Drawing.Color.White;
            this.txtSDT.BorderColor = System.Drawing.Color.Silver;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(120, 231);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(275, 44);
            this.txtSDT.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 44);
            this.label3.TabIndex = 20;
            this.label3.Text = "SĐT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BaseColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderColor = System.Drawing.Color.Silver;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDiaChi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDiaChi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(120, 120);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(275, 105);
            this.txtDiaChi.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 44);
            this.label2.TabIndex = 18;
            this.label2.Text = "Địa Chỉ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTen
            // 
            this.txtTen.BaseColor = System.Drawing.Color.White;
            this.txtTen.BorderColor = System.Drawing.Color.Silver;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(120, 63);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(275, 44);
            this.txtTen.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 44);
            this.label1.TabIndex = 16;
            this.label1.Text = "Họ Và Tên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMK
            // 
            this.txtMK.BaseColor = System.Drawing.Color.White;
            this.txtMK.BorderColor = System.Drawing.Color.Silver;
            this.txtMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMK.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMK.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMK.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(122, 486);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '\0';
            this.txtMK.SelectedText = "";
            this.txtMK.Size = new System.Drawing.Size(275, 44);
            this.txtMK.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 44);
            this.label8.TabIndex = 31;
            this.label8.Text = "Mật Khẩu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SuaSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(409, 641);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.cmbGioiTinh);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pickDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuaSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaSinhVien";
            this.Load += new System.EventHandler(this.SuaSinhVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox txtMK;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaGradientButton btnThoat;
        private Guna.UI.WinForms.GunaGradientButton btnThem;
        private System.Windows.Forms.Label lblMSSV;
        private Guna.UI.WinForms.GunaComboBox cmbGioiTinh;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDateTimePicker pickDate;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtTen;
        private System.Windows.Forms.Label label1;
    }
}