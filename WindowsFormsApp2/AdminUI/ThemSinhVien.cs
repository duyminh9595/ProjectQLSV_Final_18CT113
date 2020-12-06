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
            if (CheckTrungEmail.check(LoadExcel.lstSinhVien, LoadExcel.lstAdmin, LoadExcel.lstGV, txtEmail.Text))
            {
                if (!String.IsNullOrWhiteSpace(txtSDT.Text) && !String.IsNullOrWhiteSpace(txtTen.Text) && !String.IsNullOrWhiteSpace(txtEmail.Text)
                && !String.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    if (txtEmail.Text.Contains("@"))
                        checkThem();
                    else
                        MessageBox.Show("Emai không đúng định dạng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Chưa Nhập Đủ Thông Tin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Email bị trùng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void checkThem()
        {
            bool check = false;

            chucNangThem();
        }

        public static string mssv = "";
        private void chucNangThem()
        {
            int sl = LoadExcel.lstSinhVien.Count;
            SinhVien sv = new SinhVien();
            int slsv = 0;
            int namHoc = DateTime.Now.Year;
            List<SinhVien> lst = LoadExcel.lstSinhVien;
            /*foreach (SinhVien data in lst)
            {
                if ((data.MSSV[0].ToString() + data.MSSV[1].ToString()).Equals(namHoc.ToString()))
                {
                    ++slsv;
                }

            }*/
            foreach(NamHoc namhoc in LoadExcel.lstNam)
            {
                if(namhoc.Nam==(double)namHoc)
                {
                    slsv = (int)namhoc.SL;
                    namhoc.SL = slsv + 1;
                }
            }
            mssv = ((namHoc%100) * Math.Pow(10, 6) + (slsv+1)).ToString();
            sv.MSSV = mssv;
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
            sv.MatKhau = "a123456";
            sv.UserName = txtEmail.Text;
            DateTime iDate = pickDate.Value;
            sv.NgaySinh = DateTime.Parse(iDate.ToShortDateString());
            LoadExcel.svChuaXepLop.dsSVChuaXepLop.Add(sv);
            LoadExcel.lstSinhVien.Add(sv);
            if (sl < LoadExcel.lstSinhVien.Count)
            {
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(MessageBox.Show("Bạn Có Muốn Phân Lớp Luôn Không?", "Chấm Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PhanLopUI ui = new PhanLopUI();
                    ui.Text = "Phân Lớp Cho MSSV " + mssv;
                    ui.ShowDialog();
                }
                this.Close();
            }
            else
                MessageBox.Show("Thêm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ThemSinhVien_Load(object sender, EventArgs e)
        {
            cmbGioiTinh.SelectedItem = "Nam";
            pickDate.CustomFormat = "dd/MM/yyyy";
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
