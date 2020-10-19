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

namespace WindowsFormsApp2.AdminUI
{
    public partial class SinhVienUI : Form
    {
        public SinhVienUI()
        {
            InitializeComponent();
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            ThemSinhVien formThemSV = new ThemSinhVien();
            formThemSV.ShowDialog();
            loadDanhSachSinhVien();
        }
        BindingSource bindingSV = new BindingSource();
        List<SinhVien> lstSinhVien;
        List<SinhVien> lstPaging;
        int indexPaging = 0, totalPaging = 0;
        void tongSoTrang()
        {
            //so sv moi trang
            totalPaging = lstSinhVien.Count / 1;
        }
        void indexPagingSinhVien(int a)
        {

            lstPaging = new List<SinhVien>();
            if(lstPaging.Count>=0)
            {
                for (int i = (a - 1) * 1; i < a * 1; i++)
                {
                    if (i >= lstSinhVien.Count)
                        break;
                    lstPaging.Add(lstSinhVien[i]);
                }
            }
        }
        private void SinhVienUI_Load(object sender, EventArgs e)
        {
            lstSinhVien = LoadExcel.lstSinhVien;
            tongSoTrang();
            btnPre.Enabled = false;
            txtPage.Text = "1";
            indexPagingSinhVien(1);

            dgvThongTinhSinhVien.AutoGenerateColumns = false;
            dgvThongTinhSinhVien.DataSource = lstPaging;
            dgvThongTinhSinhVien.Columns[0].Name = "mssv"; // name
            dgvThongTinhSinhVien.Columns[0].HeaderText = "Mã Số Sinh Viên"; // header text
            dgvThongTinhSinhVien.Columns[0].DataPropertyName = "MSSV"; // field name

            dgvThongTinhSinhVien.Columns[1].HeaderText = "Họ Và Tên Sinh Viên";
            dgvThongTinhSinhVien.Columns[1].Name = "ten";
            dgvThongTinhSinhVien.Columns[1].DataPropertyName = "Ten";

            dgvThongTinhSinhVien.Columns[2].HeaderText = "Giới Tính";
            dgvThongTinhSinhVien.Columns[2].Name = "gioitinh";
            dgvThongTinhSinhVien.Columns[2].DataPropertyName = "GioiTinh";

            dgvThongTinhSinhVien.Columns[3].HeaderText = "Lớp Sinh Viên";
            dgvThongTinhSinhVien.Columns[3].Name = "tenlop";
            dgvThongTinhSinhVien.Columns[3].DataPropertyName = "Lop";

           
        }

        private void txtPage_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                loadPaging();   
            }
        }
        void loadPaging()
        {
            if (Int32.Parse(txtPage.Text) >= totalPaging)
            {
                txtPage.Text = totalPaging.ToString();
                indexPagingSinhVien(totalPaging);
                dgvThongTinhSinhVien.DataSource = lstPaging;
                btnNext.Enabled = false;
                btnPre.Enabled = true;
            }
            else if (Int32.Parse(txtPage.Text) <= 1)
            {
                indexPagingSinhVien(1);
                dgvThongTinhSinhVien.DataSource = lstPaging;
                txtPage.Text = "1";
                btnNext.Enabled = true;
                btnPre.Enabled = false;
            }
            else
            {
                indexPagingSinhVien(Int32.Parse(txtPage.Text));
                dgvThongTinhSinhVien.DataSource = lstPaging;
                btnPre.Enabled = true;
                if (lstSinhVien.Count/1> Int32.Parse(txtPage.Text))
                {
                    btnNext.Enabled = true;
                }
                else
                    btnNext.Enabled = false;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            txtPage.Text = (Int32.Parse(txtPage.Text) + 1).ToString();
            indexPagingSinhVien(Int32.Parse(txtPage.Text));
            dgvThongTinhSinhVien.DataSource = lstPaging;
            loadPaging();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            txtPage.Text = (Int32.Parse(txtPage.Text) -1).ToString();
            indexPagingSinhVien(Int32.Parse(txtPage.Text));
            dgvThongTinhSinhVien.DataSource = lstPaging;
            loadPaging();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtTimKiem.Text))
            {
                lstSinhVien = new List<SinhVien>();
                foreach(SinhVien data in LoadExcel.lstSinhVien)
                {
                    if (data.Ten.Contains(txtTimKiem.Text))
                        lstSinhVien.Add(data);
                }
                dgvThongTinhSinhVien.DataSource = null;
                tongSoTrang();
                indexPagingSinhVien(1);
                dgvThongTinhSinhVien.DataSource = lstPaging;
                if (totalPaging == 0)
                    btnNext.Enabled = false;
                else
                    btnNext.Enabled = true;
                txtPage.Text = "1";
                btnPre.Enabled = false;
            }
            else
            {
                loadDanhSachSinhVien();
            }
        }

        private void loadDanhSachSinhVien()
        {
            lstSinhVien = LoadExcel.lstSinhVien;
            tongSoTrang();
            indexPagingSinhVien(1);
            txtTimKiem.Text = "";
            dgvThongTinhSinhVien.DataSource = lstPaging;
            if (totalPaging == 0)
                btnNext.Enabled = false;
            else
                btnNext.Enabled = true;
            txtPage.Text = "1";
            btnPre.Enabled = false;
        }
    }
}
