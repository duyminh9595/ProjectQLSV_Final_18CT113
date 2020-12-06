﻿using QLSV_Library.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_Library.model;
using QLSV_Library.service;

namespace WindowsFormsApp2.User_UI
{
    public partial class DanhSachSV_User : Form
    {
        public DanhSachSV_User()
        {
            InitializeComponent();
        }

        private void DanhSachSV_User_Load(object sender, EventArgs e)
        {
            loadDGVSinhVien();
        }

        private void loadDGVSinhVien()
        {

            dgvThongTinhSinhVien.AutoGenerateColumns = false;
            foreach (SinhVien sv in LoadExcel.lstSinhVien)
            {
                if(sv.MSSV.Equals(StatusDangNhapcs.user))
                {
                    dgvThongTinhSinhVien.DataSource = LoadExcel.lstSinhVien.Where(p => p.lop == sv.lop).ToList();
                    lblTitle.Text = "Danh Sách Lớp " + sv.lop.MaLop;
                    break;
                }
            }
            dgvThongTinhSinhVien.Columns[0].Name = "mssv"; // name
            dgvThongTinhSinhVien.Columns[0].HeaderText = "Mã Số Sinh Viên"; // header text
            dgvThongTinhSinhVien.Columns[0].DataPropertyName = "MSSV"; // field name

            dgvThongTinhSinhVien.Columns[1].HeaderText = "Họ Và Tên Sinh Viên";
            dgvThongTinhSinhVien.Columns[1].Name = "ten";
            dgvThongTinhSinhVien.Columns[1].DataPropertyName = "Ten";

            dgvThongTinhSinhVien.Columns[2].HeaderText = "Giới Tính";
            dgvThongTinhSinhVien.Columns[2].Name = "gioitinh";
            dgvThongTinhSinhVien.Columns[2].DataPropertyName = "GioiTinh";

            dgvThongTinhSinhVien.Columns[3].HeaderText = "Email";
            dgvThongTinhSinhVien.Columns[3].Name = "UserName";
            dgvThongTinhSinhVien.Columns[3].DataPropertyName = "UserName";

            dgvThongTinhSinhVien.Columns[4].HeaderText = "Năm Sinh";
            dgvThongTinhSinhVien.Columns[4].Name = "namsinh";
            dgvThongTinhSinhVien.Columns[4].DataPropertyName = "NgaySinh";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}