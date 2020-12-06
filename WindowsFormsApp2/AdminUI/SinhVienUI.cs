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
            totalPaging = lstSinhVien.Count / 12;
            if (lstSinhVien.Count % 12 != 0)
                totalPaging += 1;
        }
        void indexPagingSinhVien(int a)
        {

            lstPaging = new List<SinhVien>();
            if(lstPaging.Count>=0)
            {
                for (int i = (a - 1) * 12; i < a * 12; i++)
                {
                    if (i >= lstSinhVien.Count)
                        break;
                    lstPaging.Add(lstSinhVien[i]);
                }
            }
        }
        private void SinhVienUI_Load(object sender, EventArgs e)
        {
            loadDGVSinhVien();
            btnChuyenLop.Enabled = false;
            btnPhanLop.Enabled = false;
            
        }

        private void loadDGVSinhVien()
        {
            lstSinhVien = LoadExcel.lstSinhVien;
            tongSoTrang();
            btnPre.Enabled = false;
            txtPage.Text = "1";
            indexPagingSinhVien(1);
            if (lstSinhVien.Count <= 12)
                btnNext.Enabled = false;
            else
                btnNext.Enabled = true;
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

            dgvThongTinhSinhVien.Columns[4].HeaderText = "Năm Sinh";
            dgvThongTinhSinhVien.Columns[4].Name = "namsinh";
            dgvThongTinhSinhVien.Columns[4].DataPropertyName = "NgaySinh";
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
                if (totalPaging == 1 || totalPaging == 0)
                    btnPre.Enabled = false;
            }
            else if (Int32.Parse(txtPage.Text) <= 1)
            {
                indexPagingSinhVien(1);
                dgvThongTinhSinhVien.DataSource = lstPaging;
                txtPage.Text = "1";
                btnNext.Enabled = true;
                btnPre.Enabled = false;
                if (totalPaging == 1 || totalPaging == 0)
                    btnNext.Enabled = false;
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
            if(rdbMS.Checked)
            {
                searchTheoMS();
            }
            if(rdbTen.Checked)
            {
                searchTheoTen();
            }
            if(rdbChuaLop.Checked)
            {
                searchTheoTenChuaXepLop();
            }
        }

        private void searchTheoTenChuaXepLop()
        {
            if (!String.IsNullOrEmpty(txtTimKiem.Text))
            {
                lstSinhVien = new List<SinhVien>();
                foreach (SinhVien data in LoadExcel.lstSinhVien.Where(p =>p.lop==null).ToList())
                {
                    if (data.Ten.ToLower().Contains(txtTimKiem.Text.ToLower()))
                        lstSinhVien.Add(data);
                }
                dgvThongTinhSinhVien.DataSource = null;
                tongSoTrang();
                indexPagingSinhVien(1);
                dgvThongTinhSinhVien.DataSource = lstPaging;
                if (totalPaging == 1 || totalPaging == 0)
                    btnNext.Enabled = false;
                else
                    btnNext.Enabled = true;
                txtPage.Text = "1";
                btnPre.Enabled = false;
            }
            else
            {
                svChuaXepLop();
            }
        }

        private void searchTheoMS()
        {
            if (!String.IsNullOrEmpty(txtTimKiem.Text))
            {
                lstSinhVien = new List<SinhVien>();
                foreach (SinhVien data in LoadExcel.lstSinhVien)
                {
                    if (data.MSSV.Equals(txtTimKiem.Text))
                        lstSinhVien.Add(data);
                }
                dgvThongTinhSinhVien.DataSource = null;
                tongSoTrang();
                indexPagingSinhVien(1);
                dgvThongTinhSinhVien.DataSource = lstPaging;
                if (totalPaging == 1 || totalPaging == 0)
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

        private void searchTheoTen()
        {
            if (!String.IsNullOrEmpty(txtTimKiem.Text))
            {
                lstSinhVien = new List<SinhVien>();
                foreach (SinhVien data in LoadExcel.lstSinhVien)
                {
                    if (data.Ten.ToLower().Contains(txtTimKiem.Text.ToLower()))
                        lstSinhVien.Add(data);
                }
                dgvThongTinhSinhVien.DataSource = null;
                tongSoTrang();
                indexPagingSinhVien(1);
                dgvThongTinhSinhVien.DataSource = lstPaging;
                if (totalPaging == 1 || totalPaging == 0)
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

        public static int mssvSelected = -1;
        private void dgvThongTinhSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvThongTinhSinhVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                mssvSelected = Int32.Parse(dgvThongTinhSinhVien.Rows[e.RowIndex].Cells["mssv"].FormattedValue.ToString());
            }
            foreach(SinhVien sv in LoadExcel.lstSinhVien)
            {
                if(sv.MSSV.Equals(mssvSelected.ToString()))
                {
                    if(sv.lop==null)
                    {
                        btnChuyenLop.Enabled = false;
                        btnPhanLop.Enabled = true;
                    }
                    else
                    {
                        btnChuyenLop.Enabled = true;
                        btnPhanLop.Enabled = false;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSinhVien ui = new ThemSinhVien();
            ui.ShowDialog();
            loadDGVSinhVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if(mssvSelected!=-1)
            {
                string malop = "";
                if (MessageBox.Show("Bạn Có Chắc Xóa Sinh Viên Này Không?", "Chấm Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach(SinhVien sv in LoadExcel.lstSinhVien)
                    {
                        if(sv.MSSV.Equals(mssvSelected.ToString()))
                        {
                            if(sv.TrangThaiHocXong.Equals("NO"))
                            {
                                foreach (Lop lop in LoadExcel.lstLop)
                                {
                                    if (lop.dsSinhVien.Contains(sv))
                                    {
                                        lop.dsSinhVien.Remove(sv);
                                        break;
                                    }
                                }
                                LoadExcel.lstSinhVien.Remove(sv);
                                MessageBox.Show("Xóa Thành Công");
                                break;
                            }
                            else
                            {
                                foreach (Lop lop in LoadExcel.lstLop)
                                {
                                    if (lop.dsSinhVien.Contains(sv))
                                    {
                                        malop = lop.MaLop;
                                    }
                                }
                                MessageBox.Show("Sinh viên này đang là lớp trưởng của lớp " + malop, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên cần xóa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            mssvSelected = -1;
            btnPhanLop.Enabled = false;
            btnChuyenLop.Enabled = false;
            loadDanhSachSinhVien();
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            if(mssvSelected==-1)
            {
                MessageBox.Show("Chưa Chọn Sinh Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(mssvSelected.ToString());
                SuaSinhVien sua = new SuaSinhVien();
                sua.ShowDialog();
            }
            loadDanhSachSinhVien();
            mssvSelected = -1;
            btnPhanLop.Enabled = false;
            btnChuyenLop.Enabled = false;
        }

        private void rdbChuaLop_Click(object sender, EventArgs e)
        {
            mssvSelected = -1;
            btnPhanLop.Enabled = false;
            btnChuyenLop.Enabled = false;
            svChuaXepLop();
        }

        private void svChuaXepLop()
        {

            lstSinhVien = LoadExcel.lstSinhVien.Where(p => p.lop==null).ToList();
            tongSoTrang();
            indexPagingSinhVien(1);
            txtTimKiem.Text = "";
            dgvThongTinhSinhVien.DataSource = lstPaging;
            if (totalPaging == 1 || totalPaging == 0)
                btnNext.Enabled = false;
            else
                btnNext.Enabled = true;
            txtPage.Text = "1";
            btnPre.Enabled = false;
        }

        private void rdbMS_Click(object sender, EventArgs e)
        {
            loadDanhSachSinhVien();
            mssvSelected = -1;
            btnPhanLop.Enabled = false;
            btnChuyenLop.Enabled = false;
        }

        private void rdbTen_Click(object sender, EventArgs e)
        {
            loadDanhSachSinhVien();
            mssvSelected = -1;
            btnPhanLop.Enabled = false;
            btnChuyenLop.Enabled = false;
        }
        private void btnPhanLop_Click(object sender, EventArgs e)
        {
            if(mssvSelected==-1)
            {
                MessageBox.Show("Chưa Chọn Sinh Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PhanLopFormSVUI ui = new PhanLopFormSVUI();
                ui.ShowDialog();
            }
            loadDanhSachSinhVien();
            mssvSelected = -1;
            rdbTen.Checked = true;
            btnPhanLop.Enabled = false;
            btnChuyenLop.Enabled = false;
        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
            if (mssvSelected == -1)
            {
                MessageBox.Show("Chưa Chọn Sinh Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool checkLT = false;
                string malop = "";
                foreach(SinhVien sv in LoadExcel.lstSinhVien)
                {
                    if(sv.MSSV.Equals(mssvSelected.ToString()))
                    {
                        if(sv.TrangThaiHocXong.Equals("YES"))
                        {
                            checkLT = true;
                            
                        }
                        malop = sv.lop.MaLop;
                        break;
                    }
                }
                if (checkLT == false)
                {
                    ChuyenLopFormSVUI form = new ChuyenLopFormSVUI();
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Sinh viên này đang là lớp trưởng của lớp " + malop, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            mssvSelected = -1;
            loadDanhSachSinhVien();
            btnPhanLop.Enabled = false;
            btnChuyenLop.Enabled = false;
        }

        private void dgvThongTinhSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThongTinhSinhVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                mssvSelected = Int32.Parse(dgvThongTinhSinhVien.Rows[e.RowIndex].Cells["mssv"].FormattedValue.ToString());
            }
            foreach (SinhVien sv in LoadExcel.lstSinhVien)
            {
                if (sv.MSSV.Equals(mssvSelected.ToString()))
                {
                    if (sv.lop == null)
                    {
                        btnChuyenLop.Enabled = false;
                        btnPhanLop.Enabled = true;
                    }
                    else
                    {
                        btnChuyenLop.Enabled = true;
                        btnPhanLop.Enabled = false;
                    }
                }
            }
        }

        private void loadDanhSachSinhVien()
        {
            lstSinhVien = LoadExcel.lstSinhVien;
            tongSoTrang();
            indexPagingSinhVien(1);
            txtTimKiem.Text = "";
            dgvThongTinhSinhVien.DataSource = lstPaging;
            if (totalPaging == 1||totalPaging==0)
                btnNext.Enabled = false;
            else
                btnNext.Enabled = true;
            txtPage.Text = "1";
            btnPre.Enabled = false;
        }
    }
}
