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

namespace WindowsFormsApp2.AdminUI
{
    public partial class ThemSinhVien : Form
    {
        public ThemSinhVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = 113.ToString();
            sv.Ten = txtTen.Text;
            sv.DiaChi = txtDiaChi.Text;
            sv.SDT = Int32.Parse(txtSDT.Text);
            if ((string)cmbGioiTinh.SelectedItem == "Nam")
            {

                sv.GioiTinh = "NAM";
            }
            else
                sv.GioiTinh = "NU";
            sv.TrangThaiHocXong = "NO";
            sv.UserName = txtEmail.Text;
            pickDate.CustomFormat = "dd/MM/yyyy";
            DateTime iDate = pickDate.Value;
            sv.NgaySinh = iDate;
            LoadExcel.svChuaXepLop.dsSVChuaXepLop.Add(sv);
            LoadExcel.lstSinhVien.Add(sv);
            MessageBox.Show("Thêm Thành Công","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
