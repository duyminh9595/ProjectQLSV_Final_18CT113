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

namespace WindowsFormsApp2.User_UI
{
    public partial class GiaoDienUser : Form
    {
        public GiaoDienUser()
        {
            InitializeComponent();
        }

        private void GiaoDienUser_Load(object sender, EventArgs e)
        {
            if (StatusDangNhapcs.check == 2)
            {
                lblTitle.Text = "Giao Diện Cho Lớp Trưởng, Mã Số " + StatusDangNhapcs.user;
                btnDanhSach.Enabled = true;
            }
            else if (StatusDangNhapcs.check == 1)
            {
                lblTitle.Text = "Giao Diện Cho Học Sinh, Mã Số " + StatusDangNhapcs.user;
                btnDanhSach.Enabled = false;
            }
            else
            {
                lblTitle.Text = "Giao Diện Cho Giáo Viên "+StatusDangNhapcs.user;
                btnDanhSach.Enabled = true;
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau_USer ui = new DoiMatKhau_USer();
            ui.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoadExcel.exitUI();
            Application.Exit();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            if(StatusDangNhapcs.check==3)
            {
                ThongTinGiaoVien_User ui = new ThongTinGiaoVien_User();
                ui.ShowDialog();
            }
            else
            {
                ThongTinSinhVien_User ui = new ThongTinSinhVien_User();
                ui.ShowDialog();
            }
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            if(StatusDangNhapcs.check==2)
            {
                DanhSachSV_User ui = new DanhSachSV_User();
                ui.ShowDialog();
            }
            else
            {
                DanhSachSV_GV_User ui = new DanhSachSV_GV_User();
                ui.ShowDialog();
            }
        }
    }
}
