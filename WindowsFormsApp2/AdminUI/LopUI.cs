using Guna.UI.WinForms;
using Microsoft.Reporting.WebForms;
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
    public partial class LopUI : Form
    {
        public LopUI()
        {
            InitializeComponent();
        }

        private void LopUI_Load(object sender, EventArgs e)
        {
            dgvThongTinhSinhVien.Columns[0].HeaderText = "Mã Số Sinh Viên"; // header text

            dgvThongTinhSinhVien.Columns[1].HeaderText = "Họ Và Tên Sinh Viên";

            dgvThongTinhSinhVien.Columns[2].HeaderText = "Giới Tính";

            dgvThongTinhSinhVien.Columns[3].HeaderText = "Năm Sinh";

            dgvThongTinhSinhVien.Columns[4].HeaderText = "SDT";
            /*
            dgvThongTinhSinhVien.AutoGenerateColumns = false;
            dgvThongTinhSinhVien.DataSource = LoadExcel.lstSinhVien;

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
            c
            dgvThongTinhSinhVien.Columns[4].Name = "SDT";
            dgvThongTinhSinhVien.Columns[4].DataPropertyName = "SDT";*/

            loadNamHoc();
            loadNganhHoc();
            loadLopHoc();
        }

        private void loadLopHoc()
        {
            if(checkLoadNganh==true)
            {
                cmbLop.DataSource = LoadExcel.lstLop.Where(p => p.khoa == cmbNganh.SelectedItem && p.NamNhapHoc == (double)cmbNamHoc.SelectedValue).ToList();
                cmbLop.DisplayMember = "TenLop";
                cmbLop.ValueMember = "MaLop";
            }
        }

        private void loadNganhHoc()
        {
            cmbNganh.DataSource = LoadExcel.lstKhoa;
            cmbNganh.DisplayMember = "TenKhoa";
            cmbNganh.ValueMember = "MaKhoa";
            checkLoadNganh = true;
        }
        bool checkNam = false;
        private void loadNamHoc()
        {
            cmbNamHoc.DataSource = LoadExcel.lstNam;
            cmbNamHoc.ValueMember = "Nam";
            cmbNamHoc.DisplayMember = "Nam";
            checkNam = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            /*int height = dgvThongTinhSinhVien.Height;
            dgvThongTinhSinhVien.Height = dgvThongTinhSinhVien.RowCount * dgvThongTinhSinhVien.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvThongTinhSinhVien.Width, dgvThongTinhSinhVien.Height);
            dgvThongTinhSinhVien.DrawToBitmap(bmp, new Rectangle(0, 0, dgvThongTinhSinhVien.Width, dgvThongTinhSinhVien.Height));
            dgvThongTinhSinhVien.Height = height;
            printPreviewDialog1.ShowDialog();*/
            if (dgvThongTinhSinhVien.DataSource != null)
            {
                DataSet ds = new DataSet();
                DataTable table = new DataTable();
                table.Columns.Add("Mã Số Sinh Viên", typeof(string));
                table.Columns.Add("Họ Và Tên Sinh Viên", typeof(string));
                table.Columns.Add("Giới Tính", typeof(string));
                table.Columns.Add("Ngày Sinh", typeof(string));
                table.Columns.Add("Số Điện Thoại", typeof(string));
                foreach (DataGridViewRow dt in dgvThongTinhSinhVien.Rows)
                {
                    table.Rows.Add(dt.Cells[0].Value, dt.Cells[1].Value, dt.Cells[2].Value, dt.Cells[3].Value, dt.Cells[4].Value);
                }
                ds.Tables.Add(table);
                //ds.WriteXmlSchema("applicant.xml");
                PrintTheReport p = new PrintTheReport((string)cmbLop.DisplayMember, (string)cmbLop.SelectedValue, lblMSLT.Text, lblSiSo.Text, lblGVCN.Text);
                CrystalReport2 cr = new CrystalReport2();
                cr.SetDataSource(ds);
                foreach (Lop l in LoadExcel.lstLop)
                {
                    if(l.MaLop.Equals((string)cmbLop.SelectedValue))
                    {
                        cr.SetParameterValue("tenLop", l.TenLop);
                        break;
                    }
                }
                cr.SetParameterValue("maLop", (string)cmbLop.SelectedValue);
                cr.SetParameterValue("tenGVCN", lblGVCN.Text);
                cr.SetParameterValue("namhoc", Double.Parse(cmbLop.SelectedValue.ToString().Substring(0, 2)) + 2000);
                cr.SetParameterValue("siSo", lblSiSo.Text);
                cr.SetParameterValue("msLT", lblMSLT.Text);
                p.crystalReportViewer1.ReportSource = cr;
                p.crystalReportViewer1.Refresh();
                p.Show();
            }
            else
                MessageBox.Show("Chưa Chọn Lớp Cần In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Thông Tin Lớp " +lblMaLop.Text,new Font("Arial",24,FontStyle.Bold),Brushes.Black,new PointF(260,100));
            e.Graphics.DrawString("Tên Giáo Viên Chủ Nhiệm: "+lblGVCN.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 150));
            e.Graphics.DrawString("Mã Số Lớp Trưởng: "+lblMSLT.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 190));
            e.Graphics.DrawString("Sỉ Số: "+lblSiSo.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 230));
            e.Graphics.DrawImage(bmp, 15, 300);
        }

        private void dgvThongTinhSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            dgvThongTinhSinhVien.ClearSelection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool checkLoadNganh = false;
        private void cmbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkLoadNganh==true)
            {
                cmbLop.DataSource = LoadExcel.lstLop.Where(p => p.khoa == cmbNganh.SelectedItem && p.NamNhapHoc == (double)cmbNamHoc.SelectedValue).ToList();
                cmbLop.DisplayMember = "TenLop";
                cmbLop.ValueMember = "MaLop";
            }
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkNam==true)
            {
                loadNganhHoc();

            }
            cmbLop.DataSource = null;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cmbLop.SelectedIndex!=-1)
            {
                dgvThongTinhSinhVien.AutoGenerateColumns = false;
                dgvThongTinhSinhVien.DataSource = LoadExcel.lstSinhVien.Where(p => p.lop != null && p.lop.MaLop.Equals(cmbLop.SelectedValue)).ToList();

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
                loadTest();
                lblMaLop.Text = cmbLop.SelectedValue.ToString();
                string mssvlt = "";
                int siso = 0;
                foreach (SinhVien sv in LoadExcel.lstSinhVien)
                {
                    if(sv.lop!=null)
                    {
                        if (sv.lop.MaLop.Equals(cmbLop.SelectedValue))
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
                foreach(Lop lop in LoadExcel.lstLop)
                {
                    if (lop.MaLop.Equals(cmbLop.SelectedValue))
                    {
                        if(lop.giaoVien!=null)
                            gvcn = lop.giaoVien.TenGV;
                    }
                }
                if (!String.IsNullOrEmpty(mssvlt))
                {
                    lblMSLT.Text = mssvlt;
                }
                else
                    lblMSLT.Text = "Chưa Có Lớp Trưởng";
                lblSiSo.Text = siso.ToString();
                lblGVCN.Text = gvcn;
            }
            else
            {
                lblSiSo.Text = "";
                lblMSLT.Text = "";
                lblGVCN.Text = "";
                lblMaLop.Text = "";
            }
        }

        private void loadTest()
        {
        }
    }
}
