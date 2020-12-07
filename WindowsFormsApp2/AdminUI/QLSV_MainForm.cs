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
using WindowsFormsApp2.AdminUI;

namespace WindowsFormsApp2
{
    public partial class QLSV_MainForm : Form
    {
        public QLSV_MainForm()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            pnData.Controls.Clear();
            Home formHome = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            pnData.Controls.Add(formHome);
            formHome.Show();
        }

        private void QLSV_MainForm_Load(object sender, EventArgs e)
        {
           
           DangNhap dnUI = new DangNhap();
           dnUI.ShowDialog();
        }

        private void QLSV_MainForm_Load_1(object sender, EventArgs e)
        {
            loadData();
        }

        

        

        
        private void btnDanhSachSinhVien_Click(object sender, EventArgs e)
        {

            SinhVienUI formSV = new SinhVienUI();
            formSV.ShowDialog();
        }

        private void btnGV_Click(object sender, EventArgs e)
        {

            PhanLopGiaoVien ui = new PhanLopGiaoVien();
            ui.ShowDialog();
        }

        private void btnDanhSachLop_Click(object sender, EventArgs e)
        {
            LopUI ui = new LopUI();
            ui.ShowDialog();
        }

        private void btnThemL_Click(object sender, EventArgs e)
        {
            ThemLop ui = new ThemLop();
            ui.ShowDialog();
        }

        private void btnDoiMKAdmin_Click(object sender, EventArgs e)
        {

            DoiMatKhau ui = new DoiMatKhau();
            ui.ShowDialog();
        }

        private void btnMatKhauGiaoVien_Click(object sender, EventArgs e)
        {

            DoiMatKhauGV ui = new DoiMatKhauGV();
            ui.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            LoadExcel.exitUI();
            Application.Exit();
        }
    }
}
