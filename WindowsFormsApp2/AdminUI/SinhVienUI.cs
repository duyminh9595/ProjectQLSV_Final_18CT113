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
            bindingSV.ResetBindings(false);
        }
        BindingSource bindingSV = new BindingSource();
        private void SinhVienUI_Load(object sender, EventArgs e)
        {
            bindingSV.DataSource = LoadExcel.lstSinhVien;

            dgvThongTinhSinhVien.AutoGenerateColumns = false;
            dgvThongTinhSinhVien.DataSource = bindingSV;
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtTimKiem.Text))
            {
                bindingSV.DataSource = LoadExcel.lstSinhVien.Where(x => x.Ten.Contains(txtTimKiem.Text)).ToList();
                dgvThongTinhSinhVien.DataSource = bindingSV;
            }
            else
            {
                bindingSV.DataSource = LoadExcel.lstSinhVien;
                dgvThongTinhSinhVien.DataSource = bindingSV; 
            }
        }
    }
}
