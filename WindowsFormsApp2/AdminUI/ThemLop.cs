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
    public partial class ThemLop : Form
    {
        public ThemLop()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemLop_Load(object sender, EventArgs e)
        {

            loadNamHoc();
            loadNganhHoc();
        }

        private void loadNganhHoc()
        {
            cmbNganh.DataSource = LoadExcel.lstKhoa;
            cmbNganh.DisplayMember = "TenKhoa";
            cmbNganh.ValueMember = "MaKhoa";
        }

        private void loadNamHoc()
        {
            cmbNamHoc.DataSource = LoadExcel.lstNam;
            cmbNamHoc.ValueMember = "Nam";
            cmbNamHoc.DisplayMember = "Nam";
            checkNam = true;
        }
        bool checkNam = false;

        private void btnThem_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop();
            lop.NamNhapHoc = Double.Parse(cmbNamHoc.SelectedValue.ToString());
            foreach(Khoa khoa in LoadExcel.lstKhoa)
            {
                if(khoa.MaKhoa.Equals(cmbNganh.SelectedValue.ToString()))
                {
                    lop.khoa = khoa;
                    break;
                }
            }
            int count = 0;
            foreach(Lop l in LoadExcel.lstLop)
            {
                if (l.khoa.MaKhoa.Equals(cmbNganh.SelectedValue.ToString()) && l.NamNhapHoc == Double.Parse(cmbNamHoc.SelectedValue.ToString()))
                    ++ count;
            }
            ++count;
            lop.MaLop = (lop.NamNhapHoc%100).ToString() + lop.khoa.MaKhoa+count.ToString();
            lop.TenLop = lop.khoa.TenKhoa + " " + count.ToString();
            LoadExcel.lstLop.Add(lop);
            MessageBox.Show("Thêm lớp " + lop.TenLop + " ,mã lớp: " + lop.MaLop + " thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
