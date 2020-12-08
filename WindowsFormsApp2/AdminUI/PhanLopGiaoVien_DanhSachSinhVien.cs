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
    public partial class PhanLopGiaoVien_DanhSachSinhVien : Form
    {
        public PhanLopGiaoVien_DanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void PhanLopGiaoVien_DanhSachSinhVien_Load(object sender, EventArgs e)
        {
            loadData();
            
        }

        private void loadData()
        {
            dgvThongTinhSinhVien.AutoGenerateColumns = false;
            dgvThongTinhSinhVien.DataSource = LoadExcel.lstSinhVien.Where(p => p.lop != null && p.lop.MaLop.Equals(PhanLopGiaoVien.maLopSelected)).ToList();

            dgvThongTinhSinhVien.Columns[0].Name = "mssv"; // name
            dgvThongTinhSinhVien.Columns[0].HeaderText = "Mã Số Sinh Viên"; // header text
            dgvThongTinhSinhVien.Columns[0].DataPropertyName = "MSSV"; // field name

            dgvThongTinhSinhVien.Columns[1].HeaderText = "Họ Và Tên Sinh Viên";
            dgvThongTinhSinhVien.Columns[1].Name = "ten";
            dgvThongTinhSinhVien.Columns[1].DataPropertyName = "Ten";

            dgvThongTinhSinhVien.Columns[2].HeaderText = "Giới Tính";
            dgvThongTinhSinhVien.Columns[2].Name = "gioitinh";
            dgvThongTinhSinhVien.Columns[2].DataPropertyName = "GioiTinh";

            dgvThongTinhSinhVien.Columns[3].HeaderText = "Năm Sinh";
            dgvThongTinhSinhVien.Columns[3].Name = "namsinh";
            dgvThongTinhSinhVien.Columns[3].DataPropertyName = "NgaySinh";

            dgvThongTinhSinhVien.Columns[4].HeaderText = "SDT";
            dgvThongTinhSinhVien.Columns[4].Name = "SDT";
            dgvThongTinhSinhVien.Columns[4].DataPropertyName = "SDT";

            lblMaLop.Text = PhanLopGiaoVien.maLopSelected.ToString();
            string mssvlt = "";
            int siso = 0;
            foreach (SinhVien sv in LoadExcel.lstSinhVien)
            {
                if (sv.lop != null)
                {
                    if (sv.lop.MaLop.Equals(PhanLopGiaoVien.maLopSelected))
                    {
                        if (sv.TrangThaiHocXong.Equals("YES"))
                        {
                            mssvlt = sv.MSSV;
                        }
                        ++siso;
                    }
                }
            }
            string gvcn = "";
            foreach (Lop lop in LoadExcel.lstLop)
            {
                if (lop.MaLop.Equals(PhanLopGiaoVien.maLopSelected))
                {
                    gvcn = lop.giaoVien.TenGV;
                }
            }
            if (!String.IsNullOrEmpty(mssvlt))
            {
                lblMSLT.Text = mssvlt;
            }
            else
            {
                lblMSLT.Text = "Chưa có lớp trưởng";
            }
            lblSiSo.Text = siso.ToString();
            lblGVCN.Text = gvcn;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLopTruong_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(maSV))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn mã số " + maSV + " làm lớp trưởng lớp " + PhanLopGiaoVien.maLopSelected, "Xác Nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (Lop lop in LoadExcel.lstLop)
                    {
                        if (lop.MaLop.Equals(PhanLopGiaoVien.maLopSelected))
                        {
                            foreach (SinhVien sv in lop.dsSinhVien)
                            {
                                if (sv.MSSV.Equals(maSV))
                                {
                                    sv.TrangThaiHocXong = "YES";
                                }
                                else
                                    sv.TrangThaiHocXong = "NO";
                            }
                        }
                    }
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Chưa Chọn Sinh Viên Để Làm Lớp Trưởng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string maSV;
        private void dgvThongTinhSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThongTinhSinhVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                maSV = dgvThongTinhSinhVien.Rows[e.RowIndex].Cells["MSSV"].FormattedValue.ToString();
        }
    }
    
}
