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
    public partial class PhanLopGiaoVien_GiaoVien : Form
    {
        public PhanLopGiaoVien_GiaoVien()
        {
            InitializeComponent();
        }
        string magv = "";
        private void dgvGVCN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGVCN.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                magv = dgvGVCN.Rows[e.RowIndex].Cells["MaGV"].FormattedValue.ToString();
            }
        }

        private void dgvGVCN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGVCN.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                magv = dgvGVCN.Rows[e.RowIndex].Cells["MaGV"].FormattedValue.ToString();
            }
        }

        private void PhanLopGiaoVien_GiaoVien_Load(object sender, EventArgs e)
        {
            loadGVC();
        }

        private void loadGVC()
        {
            dgvGVCN.DataSource = null;
            dgvGVCN.AutoGenerateColumns = false;
            dgvGVCN.DataSource = LoadExcel.lstGV;
            dgvGVCN.Columns[0].Name = "MaGV"; // name
            dgvGVCN.Columns[0].HeaderText = "Mã GV"; // header text
            dgvGVCN.Columns[0].DataPropertyName = "MaGV"; // field name

            dgvGVCN.Columns[1].HeaderText = "Tên GV";
            dgvGVCN.Columns[1].Name = "ten";
            dgvGVCN.Columns[1].DataPropertyName = "TenGV";

            dgvGVCN.Columns[2].HeaderText = "Email";
            dgvGVCN.Columns[2].Name = "email";
            dgvGVCN.Columns[2].DataPropertyName = "Email";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGVCN_Click(object sender, EventArgs e)
        {
            string tengv = "";
            foreach(GiaoVien gv in LoadExcel.lstGV)
            {
                if(gv.MaGV.Equals(magv))
                {
                    tengv = gv.TenGV;
                    foreach(Lop lop in LoadExcel.lstLop)
                    {
                        if(lop.MaLop.Equals(PhanLopGiaoVien.maLopSelected))
                        {
                            lop.giaoVien = gv;
                            break;
                        }
                    }
                    break;
                }
            }

            MessageBox.Show("Phân Giáo viên " + tengv + " chủ nhiệm lớp " + PhanLopGiaoVien.maLopSelected, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvGVCN.DataSource = null;
            dgvGVCN.AutoGenerateColumns = false;
            dgvGVCN.DataSource = LoadExcel.lstGV.Where(p => p.MaGV.Contains(txtGV.Text)||p.TenGV.ToUpper().Contains(txtGV.Text.ToUpper())).ToList();
            dgvGVCN.Columns[0].Name = "magv"; // name
            dgvGVCN.Columns[0].HeaderText = "Mã GV"; // header text
            dgvGVCN.Columns[0].DataPropertyName = "MaGV"; // field name

            dgvGVCN.Columns[1].HeaderText = "Tên GV";
            dgvGVCN.Columns[1].Name = "ten";
            dgvGVCN.Columns[1].DataPropertyName = "TenGV";

            dgvGVCN.Columns[2].HeaderText = "Email";
            dgvGVCN.Columns[2].Name = "email";
            dgvGVCN.Columns[2].DataPropertyName = "Email";
        }
    }
}
