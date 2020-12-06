using QLSV_Library.model;
using QLSV_Library.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.AdminUI
{
    public partial class SuaSinhVien : Form
    {
        public SuaSinhVien()
        {
            InitializeComponent();
        }

        private void SuaSinhVien_Load(object sender, EventArgs e)
        {
            int ms = SinhVienUI.mssvSelected;
            lblMSSV.Text = "Mã Số SV: " + ms.ToString();
            foreach (SinhVien sv in LoadExcel.lstSinhVien)
            {
                if (sv.MSSV.Equals(ms.ToString()))
                {
                    txtDiaChi.Text = sv.DiaChi;
                    txtEmail.Text = sv.UserName;
                    txtMK.Text = sv.MatKhau;
                    txtSDT.Text = sv.SDT.ToString();
                    txtTen.Text = sv.Ten;
                    if (sv.GioiTinh.Equals("NAM"))
                    {
                        cmbGioiTinh.SelectedItem = "NAM";
                    }
                    else
                        cmbGioiTinh.SelectedItem = "NU";
                    pickDate.Value = sv.NgaySinh;
                    break;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtSDT.Text) && !String.IsNullOrWhiteSpace(txtTen.Text) && !String.IsNullOrWhiteSpace(txtEmail.Text)
                && !String.IsNullOrWhiteSpace(txtDiaChi.Text) && !String.IsNullOrWhiteSpace(txtMK.Text))
            {
                foreach (SinhVien sv in LoadExcel.lstSinhVien)
                {
                    if (sv.MSSV.Equals(SinhVienUI.mssvSelected.ToString()))
                    {

                        sv.Ten = txtTen.Text;
                        sv.DiaChi = txtDiaChi.Text;
                        sv.SDT = Int32.Parse(txtSDT.Text);
                        if ((string)cmbGioiTinh.SelectedItem == "NAM")
                        {

                            sv.GioiTinh = "NAM";
                        }
                        else
                            sv.GioiTinh = "NU";
                        sv.MatKhau = txtMK.Text;
                        DateTime iDate = pickDate.Value;
                        sv.NgaySinh = DateTime.Parse(iDate.ToShortDateString());
                        sv.UserName = txtEmail.Text;
                        MessageBox.Show("Sửa Thông Tin Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa Nhập Đủ Thông Tin", "Chấm Hỏi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
