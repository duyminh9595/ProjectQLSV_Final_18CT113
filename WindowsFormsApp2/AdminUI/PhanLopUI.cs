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
    public partial class PhanLopUI : Form
    {
        public PhanLopUI()
        {
            InitializeComponent();
        }

        private void PhanLopUI_Load(object sender, EventArgs e)
        {
            loadNganh();
            loadLop();
        }

        private void loadLop()
        {
            if(loadNganhCheck==true)
            {
                string makhoa=cmbNganh.SelectedValue.ToString();
                cmbLop.DataSource = LoadExcel.lstLop.Where(p => (p.MaLop.Contains(makhoa) && (p.NamNhapHoc == DateTime.Now.Year))).ToList();
                cmbLop.DisplayMember = "TenLop";
                cmbLop.ValueMember = "MaLop";
            }
        }

        private void loadNganh()
        {
            cmbNganh.DataSource = LoadExcel.lstKhoa;
            cmbNganh.DisplayMember = "TenKhoa";
            cmbNganh.ValueMember = "MaKhoa";
            loadNganhCheck = true; 
        }
        bool loadNganhCheck = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ms = ThemSinhVien.mssv;
            foreach(Lop slop in LoadExcel.lstLop)
            {
                if(slop.MaLop.Equals(cmbLop.SelectedValue.ToString()))
                {
                    foreach (SinhVien sv in LoadExcel.lstSinhVien)
                    {
                        if (sv.MSSV.Equals(ms))
                        {
                            sv.lop = slop;
                            slop.dsSinhVien.Add(sv);
                            MessageBox.Show("Phân Lớp Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }

                    break;
                }
            }
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chưa Phân Lớp Cho Học Sinh Này?", "Chấm Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void cmbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(loadNganhCheck==true)
            {
                string makhoa =cmbNganh.SelectedValue.ToString();
                cmbLop.DataSource = null;
                cmbLop.DataSource = LoadExcel.lstLop.Where(p => (p.MaLop.Contains(makhoa) && (p.NamNhapHoc == DateTime.Now.Year))).ToList();
                cmbLop.DisplayMember = "TenLop";
                cmbLop.ValueMember = "MaLop";
            }
        }
    }
}
