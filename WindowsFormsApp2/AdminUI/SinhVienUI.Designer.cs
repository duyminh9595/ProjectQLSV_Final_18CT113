namespace WindowsFormsApp2.AdminUI
{
    partial class SinhVienUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinhVienUI));
            this.dgvThongTinhSinhVien = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnTimKiem = new Guna.UI.WinForms.GunaImageButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnPre = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnThemSinhVien = new Guna.UI.WinForms.GunaGroupBox();
            this.btnThoat = new Guna.UI.WinForms.GunaButton();
            this.btnXoaSV = new Guna.UI.WinForms.GunaButton();
            this.btnSuaSV = new Guna.UI.WinForms.GunaButton();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.rdbChuaLop = new Guna.UI.WinForms.GunaRadioButton();
            this.rdbMS = new Guna.UI.WinForms.GunaRadioButton();
            this.rdbTen = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnChuyenLop = new Guna.UI.WinForms.GunaButton();
            this.btnPhanLop = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinhSinhVien)).BeginInit();
            this.btnThemSinhVien.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinhSinhVien
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvThongTinhSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThongTinhSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinhSinhVien.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvThongTinhSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTinhSinhVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinhSinhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinhSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThongTinhSinhVien.ColumnHeadersHeight = 26;
            this.dgvThongTinhSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinhSinhVien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvThongTinhSinhVien.EnableHeadersVisualStyles = false;
            this.dgvThongTinhSinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinhSinhVien.Location = new System.Drawing.Point(13, 294);
            this.dgvThongTinhSinhVien.MultiSelect = false;
            this.dgvThongTinhSinhVien.Name = "dgvThongTinhSinhVien";
            this.dgvThongTinhSinhVien.RowHeadersVisible = false;
            this.dgvThongTinhSinhVien.RowTemplate.Height = 25;
            this.dgvThongTinhSinhVien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvThongTinhSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinhSinhVien.Size = new System.Drawing.Size(903, 324);
            this.dgvThongTinhSinhVien.TabIndex = 1;
            this.dgvThongTinhSinhVien.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvThongTinhSinhVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinhSinhVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongTinhSinhVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinhSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongTinhSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinhSinhVien.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvThongTinhSinhVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinhSinhVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvThongTinhSinhVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongTinhSinhVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongTinhSinhVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongTinhSinhVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongTinhSinhVien.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvThongTinhSinhVien.ThemeStyle.ReadOnly = false;
            this.dgvThongTinhSinhVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinhSinhVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinhSinhVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongTinhSinhVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongTinhSinhVien.ThemeStyle.RowsStyle.Height = 25;
            this.dgvThongTinhSinhVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinhSinhVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongTinhSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinhSinhVien_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTimKiem.Location = new System.Drawing.Point(187, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(270, 65);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.Image = null;
            this.btnTimKiem.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTimKiem.Location = new System.Drawing.Point(484, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(72, 64);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this.btnTimKiem;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(315, 626);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 4;
            this.btnPre.Text = "Previous";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(397, 626);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(100, 22);
            this.txtPage.TabIndex = 5;
            this.txtPage.TextChanged += new System.EventHandler(this.txtPage_TextChanged);
            this.txtPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPage_KeyPress);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(503, 625);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.btnThemSinhVien.BaseColor = System.Drawing.Color.White;
            this.btnThemSinhVien.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnThemSinhVien.Controls.Add(this.btnThoat);
            this.btnThemSinhVien.Controls.Add(this.btnXoaSV);
            this.btnThemSinhVien.Controls.Add(this.btnSuaSV);
            this.btnThemSinhVien.Controls.Add(this.btnThem);
            this.btnThemSinhVien.LineColor = System.Drawing.Color.Gainsboro;
            this.btnThemSinhVien.Location = new System.Drawing.Point(724, 13);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(192, 275);
            this.btnThemSinhVien.TabIndex = 7;
            this.btnThemSinhVien.Text = "Chức Năng";
            this.btnThemSinhVien.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnThoat
            // 
            this.btnThoat.AnimationHoverSpeed = 0.07F;
            this.btnThoat.AnimationSpeed = 0.03F;
            this.btnThoat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThoat.BorderColor = System.Drawing.Color.Black;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.FocusedColor = System.Drawing.Color.Empty;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = null;
            this.btnThoat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThoat.Location = new System.Drawing.Point(4, 217);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Size = new System.Drawing.Size(185, 42);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.AnimationHoverSpeed = 0.07F;
            this.btnXoaSV.AnimationSpeed = 0.03F;
            this.btnXoaSV.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnXoaSV.BorderColor = System.Drawing.Color.Black;
            this.btnXoaSV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaSV.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaSV.ForeColor = System.Drawing.Color.White;
            this.btnXoaSV.Image = null;
            this.btnXoaSV.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoaSV.Location = new System.Drawing.Point(4, 157);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoaSV.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoaSV.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoaSV.OnHoverImage = null;
            this.btnXoaSV.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoaSV.Size = new System.Drawing.Size(185, 42);
            this.btnXoaSV.TabIndex = 2;
            this.btnXoaSV.Text = "Xóa Sinh Viên";
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.AnimationHoverSpeed = 0.07F;
            this.btnSuaSV.AnimationSpeed = 0.03F;
            this.btnSuaSV.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSuaSV.BorderColor = System.Drawing.Color.Black;
            this.btnSuaSV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuaSV.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaSV.ForeColor = System.Drawing.Color.White;
            this.btnSuaSV.Image = null;
            this.btnSuaSV.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSuaSV.Location = new System.Drawing.Point(4, 99);
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSuaSV.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuaSV.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuaSV.OnHoverImage = null;
            this.btnSuaSV.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaSV.Size = new System.Drawing.Size(185, 42);
            this.btnSuaSV.TabIndex = 1;
            this.btnSuaSV.Text = "Sửa Thông Tin";
            this.btnSuaSV.Click += new System.EventHandler(this.btnSuaSV_Click);
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = null;
            this.btnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(4, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Size = new System.Drawing.Size(185, 42);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm Sinh Viên";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.rdbChuaLop);
            this.gunaGroupBox1.Controls.Add(this.rdbMS);
            this.gunaGroupBox1.Controls.Add(this.rdbTen);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 85);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(705, 69);
            this.gunaGroupBox1.TabIndex = 8;
            this.gunaGroupBox1.Text = "Tìm Kiếm Theo";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // rdbChuaLop
            // 
            this.rdbChuaLop.BaseColor = System.Drawing.SystemColors.Control;
            this.rdbChuaLop.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbChuaLop.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdbChuaLop.FillColor = System.Drawing.Color.White;
            this.rdbChuaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChuaLop.Location = new System.Drawing.Point(384, 32);
            this.rdbChuaLop.Name = "rdbChuaLop";
            this.rdbChuaLop.Size = new System.Drawing.Size(259, 26);
            this.rdbChuaLop.TabIndex = 2;
            this.rdbChuaLop.Text = "Chưa Xếp Lớp (Theo Tên)";
            this.rdbChuaLop.Click += new System.EventHandler(this.rdbChuaLop_Click);
            // 
            // rdbMS
            // 
            this.rdbMS.BaseColor = System.Drawing.SystemColors.Control;
            this.rdbMS.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbMS.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdbMS.FillColor = System.Drawing.Color.White;
            this.rdbMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMS.Location = new System.Drawing.Point(209, 32);
            this.rdbMS.Name = "rdbMS";
            this.rdbMS.Size = new System.Drawing.Size(149, 26);
            this.rdbMS.TabIndex = 1;
            this.rdbMS.Text = "Tìm Theo MS";
            this.rdbMS.Click += new System.EventHandler(this.rdbMS_Click);
            // 
            // rdbTen
            // 
            this.rdbTen.BaseColor = System.Drawing.SystemColors.Control;
            this.rdbTen.Checked = true;
            this.rdbTen.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbTen.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdbTen.FillColor = System.Drawing.Color.White;
            this.rdbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTen.Location = new System.Drawing.Point(4, 32);
            this.rdbTen.Name = "rdbTen";
            this.rdbTen.Size = new System.Drawing.Size(154, 26);
            this.rdbTen.TabIndex = 0;
            this.rdbTen.Text = "Tìm Theo Tên";
            this.rdbTen.Click += new System.EventHandler(this.rdbTen_Click);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.btnChuyenLop);
            this.gunaGroupBox2.Controls.Add(this.btnPhanLop);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(12, 170);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(705, 118);
            this.gunaGroupBox2.TabIndex = 9;
            this.gunaGroupBox2.Text = "Phân Lớp Và Chuyển Lớp";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnChuyenLop
            // 
            this.btnChuyenLop.AnimationHoverSpeed = 0.07F;
            this.btnChuyenLop.AnimationSpeed = 0.03F;
            this.btnChuyenLop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnChuyenLop.BorderColor = System.Drawing.Color.Black;
            this.btnChuyenLop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChuyenLop.FocusedColor = System.Drawing.Color.Empty;
            this.btnChuyenLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuyenLop.ForeColor = System.Drawing.Color.White;
            this.btnChuyenLop.Image = null;
            this.btnChuyenLop.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChuyenLop.Location = new System.Drawing.Point(359, 36);
            this.btnChuyenLop.Name = "btnChuyenLop";
            this.btnChuyenLop.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChuyenLop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChuyenLop.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChuyenLop.OnHoverImage = null;
            this.btnChuyenLop.OnPressedColor = System.Drawing.Color.Black;
            this.btnChuyenLop.Size = new System.Drawing.Size(185, 79);
            this.btnChuyenLop.TabIndex = 5;
            this.btnChuyenLop.Text = "Chuyển Lớp";
            this.btnChuyenLop.Click += new System.EventHandler(this.btnChuyenLop_Click);
            // 
            // btnPhanLop
            // 
            this.btnPhanLop.AnimationHoverSpeed = 0.07F;
            this.btnPhanLop.AnimationSpeed = 0.03F;
            this.btnPhanLop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPhanLop.BorderColor = System.Drawing.Color.Black;
            this.btnPhanLop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPhanLop.FocusedColor = System.Drawing.Color.Empty;
            this.btnPhanLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPhanLop.ForeColor = System.Drawing.Color.White;
            this.btnPhanLop.Image = null;
            this.btnPhanLop.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPhanLop.Location = new System.Drawing.Point(144, 36);
            this.btnPhanLop.Name = "btnPhanLop";
            this.btnPhanLop.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPhanLop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPhanLop.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPhanLop.OnHoverImage = null;
            this.btnPhanLop.OnPressedColor = System.Drawing.Color.Black;
            this.btnPhanLop.Size = new System.Drawing.Size(185, 79);
            this.btnPhanLop.TabIndex = 4;
            this.btnPhanLop.Text = "Phân Lớp";
            this.btnPhanLop.Click += new System.EventHandler(this.btnPhanLop_Click);
            // 
            // SinhVienUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 680);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.btnThemSinhVien);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvThongTinhSinhVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SinhVienUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SinhVienUI";
            this.Load += new System.EventHandler(this.SinhVienUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinhSinhVien)).EndInit();
            this.btnThemSinhVien.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dgvThongTinhSinhVien;
        private Guna.UI.WinForms.GunaLineTextBox txtTimKiem;
        private Guna.UI.WinForms.GunaImageButton btnTimKiem;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI.WinForms.GunaGroupBox btnThemSinhVien;
        private Guna.UI.WinForms.GunaButton btnThem;
        private Guna.UI.WinForms.GunaButton btnThoat;
        private Guna.UI.WinForms.GunaButton btnXoaSV;
        private Guna.UI.WinForms.GunaButton btnSuaSV;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaRadioButton rdbMS;
        private Guna.UI.WinForms.GunaRadioButton rdbTen;
        private Guna.UI.WinForms.GunaRadioButton rdbChuaLop;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaButton btnChuyenLop;
        private Guna.UI.WinForms.GunaButton btnPhanLop;
    }
}