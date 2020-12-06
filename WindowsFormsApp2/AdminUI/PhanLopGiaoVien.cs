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
    public partial class PhanLopGiaoVien : Form
    {
        public PhanLopGiaoVien()
        {
            InitializeComponent();
        }

        private void PhanLopGiaoVien_Load(object sender, EventArgs e)
        {
            loadDS();
            btnChiTiet.Enabled = false;
            btnPhanGiaoVien.Enabled = false;
        }

        private void loadDS()
        {
            dgvLop.DataSource = null;
            dgvLop.AutoGenerateColumns = false;
            dgvLop.DataSource = LoadExcel.lstLop;
            dgvLop.Columns[0].Name = "malop"; // name
            dgvLop.Columns[0].HeaderText = "Mã Lớp"; // header text
            dgvLop.Columns[0].DataPropertyName = "MaLop"; // field name

            dgvLop.Columns[1].HeaderText = "Tên Lớp";
            dgvLop.Columns[1].Name = "ten";
            dgvLop.Columns[1].DataPropertyName = "TenLop";

            dgvLop.Columns[2].HeaderText = "Năm";
            dgvLop.Columns[2].Name = "nam";
            dgvLop.Columns[2].DataPropertyName = "NamNhapHoc";

            dgvLop.Columns[3].HeaderText = "Giáo Viên";
            dgvLop.Columns[3].Name = "namsinh";
            dgvLop.Columns[3].DataPropertyName = "TenGV";

            dgvLop.Columns[4].HeaderText = "Sỉ Số";
            dgvLop.Columns[4].Name = "siso";
            dgvLop.Columns[4].DataPropertyName = "sisoLop";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTen.Text))
                loadDS();
            else
            {
                dgvLop.DataSource = null;
                dgvLop.AutoGenerateColumns = false;
                dgvLop.DataSource = LoadExcel.lstLop.Where(p => p.giaoVien.TenGV.ToUpper().Contains(txtTen.Text.ToUpper()) ||p.MaLop.ToUpper().Equals(txtTen.Text.ToUpper())).ToList();
                dgvLop.Columns[0].Name = "malop"; // name
                dgvLop.Columns[0].HeaderText = "Mã Lớp"; // header text
                dgvLop.Columns[0].DataPropertyName = "MaLop"; // field name

                dgvLop.Columns[1].HeaderText = "Tên Lớp";
                dgvLop.Columns[1].Name = "ten";
                dgvLop.Columns[1].DataPropertyName = "TenLop";

                dgvLop.Columns[2].HeaderText = "Năm";
                dgvLop.Columns[2].Name = "nam";
                dgvLop.Columns[2].DataPropertyName = "NamNhapHoc";

                dgvLop.Columns[3].HeaderText = "Giáo Viên";
                dgvLop.Columns[3].Name = "namsinh";
                dgvLop.Columns[3].DataPropertyName = "TenGV";

                dgvLop.Columns[4].HeaderText = "Sỉ Số";
                dgvLop.Columns[4].Name = "siso";
                dgvLop.Columns[4].DataPropertyName = "sisoLop";
            }
        }
        public static string maLopSelected = "";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            bool checkGV = false;
            foreach(Lop lop in LoadExcel.lstLop)
            {
                if(lop.MaLop.Equals(maLopSelected))
                {
                    if(lop.giaoVien!=null)
                    {
                        checkGV = true;
                    }
                    break;
                }
            }    
            if (!String.IsNullOrEmpty(maLopSelected))
            {
                if (checkGV == true)
                {
                    PhanLopGiaoVien_DanhSachSinhVien ui = new PhanLopGiaoVien_DanhSachSinhVien();
                    ui.ShowDialog();
                }
                else
                    MessageBox.Show("Lớp chưa có giáo viên chủ nhiệm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Chưa Chọn Lớp Cần Hiện Danh Sách", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnPhanGiaoVien_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(maLopSelected))
            {
                foreach(Lop lop in LoadExcel.lstLop)
                {
                    if(lop.MaLop.Equals(maLopSelected))
                    {
                        if (lop.giaoVien!=null)
                            MessageBox.Show("Lớp này đã có giáo viên dạy","Chẩm hỏi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        else
                        {
                            PhanLopGiaoVien_GiaoVien ui = new PhanLopGiaoVien_GiaoVien();
                            ui.ShowDialog();
                            loadDS();
                        }
                    }
                }
            }
            else
                MessageBox.Show("Chưa Chọn Lớp Cần Phân Công Giáo Viên", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLop.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                maLopSelected = dgvLop.Rows[e.RowIndex].Cells["MaLop"].FormattedValue.ToString();
                btnPhanGiaoVien.Enabled = true;
                btnChiTiet.Enabled = true;
            }
        }
    }
}
