using QLSV_Library.model;
using QLSV_Library.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.AdminUI
{
    public partial class ChuyenLopFormSVUI : Form
    {
        public ChuyenLopFormSVUI()
        {
            InitializeComponent();
        }
        Lop lopSelected;
        SinhVien svSelected;
        private void ChuyenLopFormSVUI_Load(object sender, EventArgs e)
        {
            int ms = SinhVienUI.mssvSelected;
            lblMSSV.Text = "Chuyển Lớp Cho MS  " + ms.ToString();
            foreach(Lop lop in LoadExcel.lstLop)
            {
                foreach(SinhVien sv in lop.dsSinhVien)
                {
                    if(sv.MSSV.Equals(ms.ToString()))
                    {
                        lopSelected = lop;
                        svSelected = sv;
                        break;
                    }
                }
            }
            lblLopCu.Text=lopSelected.MaLop+"("+lopSelected.NamNhapHoc + ")";
            loadNganh();
            loadLop();
        }

        bool loadNganhCheck = false;
        private void loadLop()
        {
            if (loadNganhCheck == true)
            {
                string makhoa = cmbNganh.SelectedValue.ToString();
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

        private void cmbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadNganhCheck == true)
            {
                string makhoa = cmbNganh.SelectedValue.ToString();
                cmbLop.DataSource = null;
                cmbLop.DataSource = LoadExcel.lstLop.Where(p => (p.MaLop.Contains(makhoa) && (p.NamNhapHoc == DateTime.Now.Year))).ToList();
                cmbLop.DisplayMember = "TenLop";
                cmbLop.ValueMember = "MaLop";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (Lop slop in LoadExcel.lstLop)
            {
                if (slop.MaLop.Equals(cmbLop.SelectedValue.ToString()))
                {

                    svSelected.lop = slop;
                    slop.dsSinhVien.Add(svSelected);
                    lopSelected.dsSinhVien.Remove(svSelected);
                    MessageBox.Show("Chuyển Lớp Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = true;
                    break;
                }
                    if(check)
                        break;
                
            }
            this.Close();
        }
    }
}
