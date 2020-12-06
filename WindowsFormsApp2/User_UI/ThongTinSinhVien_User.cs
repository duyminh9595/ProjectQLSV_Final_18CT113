using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_Library.service;
using QLSV_Library.model;

namespace WindowsFormsApp2.User_UI
{
    public partial class ThongTinSinhVien_User : Form
    {
        public ThongTinSinhVien_User()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinSinhVien_User_Load(object sender, EventArgs e)
        {
            int ms = Int32.Parse(StatusDangNhapcs.user);
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
    }
}
