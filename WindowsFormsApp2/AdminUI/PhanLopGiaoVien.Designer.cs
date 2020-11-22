namespace WindowsFormsApp2.AdminUI
{
    partial class PhanLopGiaoVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLop = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtTen = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnTim = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnChiTiet = new Guna.UI.WinForms.GunaButton();
            this.btnThoat = new Guna.UI.WinForms.GunaButton();
            this.btnPhanGiaoVien = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLop
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvLop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLop.ColumnHeadersHeight = 26;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLop.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLop.EnableHeadersVisualStyles = false;
            this.dgvLop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLop.Location = new System.Drawing.Point(12, 114);
            this.dgvLop.MultiSelect = false;
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersVisible = false;
            this.dgvLop.RowTemplate.Height = 25;
            this.dgvLop.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.Size = new System.Drawing.Size(776, 324);
            this.dgvLop.TabIndex = 2;
            this.dgvLop.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLop.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvLop.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLop.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvLop.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLop.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLop.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLop.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLop.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvLop.ThemeStyle.ReadOnly = false;
            this.dgvLop.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLop.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLop.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLop.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLop.ThemeStyle.RowsStyle.Height = 25;
            this.dgvLop.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLop.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 109;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.btnTim);
            this.gunaGroupBox1.Controls.Add(this.txtTen);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(429, 85);
            this.gunaGroupBox1.TabIndex = 3;
            this.gunaGroupBox1.Text = "Tìm Kiếm";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.White;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTen.Location = new System.Drawing.Point(3, 38);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(248, 41);
            this.txtTen.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.AnimationHoverSpeed = 0.07F;
            this.btnTim.AnimationSpeed = 0.03F;
            this.btnTim.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTim.BorderColor = System.Drawing.Color.Black;
            this.btnTim.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTim.FocusedColor = System.Drawing.Color.Empty;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Image = null;
            this.btnTim.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTim.Location = new System.Drawing.Point(287, 38);
            this.btnTim.Name = "btnTim";
            this.btnTim.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTim.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTim.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTim.OnHoverImage = null;
            this.btnTim.OnPressedColor = System.Drawing.Color.Black;
            this.btnTim.Size = new System.Drawing.Size(139, 42);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.btnPhanGiaoVien);
            this.gunaGroupBox2.Controls.Add(this.btnThoat);
            this.gunaGroupBox2.Controls.Add(this.btnChiTiet);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(458, 12);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(330, 85);
            this.gunaGroupBox2.TabIndex = 4;
            this.gunaGroupBox2.Text = "Chức Năng";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.AnimationHoverSpeed = 0.07F;
            this.btnChiTiet.AnimationSpeed = 0.03F;
            this.btnChiTiet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnChiTiet.BorderColor = System.Drawing.Color.Black;
            this.btnChiTiet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChiTiet.FocusedColor = System.Drawing.Color.Empty;
            this.btnChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnChiTiet.Image = null;
            this.btnChiTiet.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChiTiet.Location = new System.Drawing.Point(3, 37);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChiTiet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChiTiet.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChiTiet.OnHoverImage = null;
            this.btnChiTiet.OnPressedColor = System.Drawing.Color.Black;
            this.btnChiTiet.Size = new System.Drawing.Size(102, 42);
            this.btnChiTiet.TabIndex = 1;
            this.btnChiTiet.Text = "Danh Sách";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
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
            this.btnThoat.Location = new System.Drawing.Point(219, 38);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Size = new System.Drawing.Size(102, 42);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Exit";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnPhanGiaoVien
            // 
            this.btnPhanGiaoVien.AnimationHoverSpeed = 0.07F;
            this.btnPhanGiaoVien.AnimationSpeed = 0.03F;
            this.btnPhanGiaoVien.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPhanGiaoVien.BorderColor = System.Drawing.Color.Black;
            this.btnPhanGiaoVien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPhanGiaoVien.FocusedColor = System.Drawing.Color.Empty;
            this.btnPhanGiaoVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPhanGiaoVien.ForeColor = System.Drawing.Color.White;
            this.btnPhanGiaoVien.Image = null;
            this.btnPhanGiaoVien.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPhanGiaoVien.Location = new System.Drawing.Point(111, 38);
            this.btnPhanGiaoVien.Name = "btnPhanGiaoVien";
            this.btnPhanGiaoVien.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPhanGiaoVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPhanGiaoVien.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPhanGiaoVien.OnHoverImage = null;
            this.btnPhanGiaoVien.OnPressedColor = System.Drawing.Color.Black;
            this.btnPhanGiaoVien.Size = new System.Drawing.Size(102, 42);
            this.btnPhanGiaoVien.TabIndex = 3;
            this.btnPhanGiaoVien.Text = "Phân Công GV";
            this.btnPhanGiaoVien.Click += new System.EventHandler(this.btnPhanGiaoVien_Click);
            // 
            // PhanLopGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.dgvLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhanLopGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhanLopGiaoVien";
            this.Load += new System.EventHandler(this.PhanLopGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLineTextBox txtTen;
        private Guna.UI.WinForms.GunaButton btnTim;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaButton btnChiTiet;
        private Guna.UI.WinForms.GunaButton btnPhanGiaoVien;
        private Guna.UI.WinForms.GunaButton btnThoat;
    }
}