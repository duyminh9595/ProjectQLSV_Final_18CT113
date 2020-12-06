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
    public partial class DanhSachSV_GV_User : Form
    {
        public DanhSachSV_GV_User()
        {
            InitializeComponent();
        }

        private void DanhSachSV_GV_User_Load(object sender, EventArgs e)
        {
            loadNamHoc();
            loadLop();
        }
        private void loadLop()
        {
            if(checkNam==true)
            {
                MessageBox.Show(cmbNamHoc.SelectedValue.ToString());
                cmbLop.DataSource = LoadExcel.lstLop.Where(p =>p.giaoVien!=null&& p.NamNhapHoc == (double)cmbNamHoc.SelectedValue && p.giaoVien.MaGV.Equals(StatusDangNhapcs.user)).ToList();
                cmbLop.DisplayMember = "TenLop";
                cmbLop.ValueMember = "MaLop";
            }
        }

        bool checkNam = false;
        private void loadNamHoc()
        {
            cmbNamHoc.DataSource = LoadExcel.lstNam;
            cmbNamHoc.ValueMember = "Nam";
            cmbNamHoc.DisplayMember = "Nam";
            checkNam = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string lop = cmbLop.SelectedValue.ToString();
            dgvThongTinhSinhVien.AutoGenerateColumns = false;
            foreach(Lop l in LoadExcel.lstLop)
            {
                if(l.MaLop.Equals(lop))
                {
                    dgvThongTinhSinhVien.DataSource = l.dsSinhVien;
                    break;
                }
            }
            lblTitle.Text = "Danh Sách Lớp " + lop;
             
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

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLop.DataSource = null;
            dgvThongTinhSinhVien.DataSource = null;
            loadLop();
        }

        private void cmbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvThongTinhSinhVien.DataSource = null;
        }
    }
}
