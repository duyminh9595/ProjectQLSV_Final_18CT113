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
using QLSV_Library;

namespace WindowsFormsApp2
{
    public partial class QuanLySinhVienUI : Form
    {
        public QuanLySinhVienUI()
        {
            InitializeComponent();
        }
        LoadExcel data;
        BindingSource khoaBinDing = new BindingSource();
        BindingSource lopBinDing = new BindingSource();
        BindingSource svBinDing = new BindingSource();
        bool checkLoadKhoa = false;
        bool checkLoadLop = false;
        private void QuanLySinhVienUI_Load(object sender, EventArgs e)
        {
            data = new LoadExcel();
            DangNhap dnUI = new DangNhap();
            dnUI.ShowDialog();
            if (StatusDangNhapcs.check==true)
            {
                khoaBinDing.DataSource = data.lstKhoa;
                lsKhoa.DataSource = khoaBinDing;
                lsKhoa.DisplayMember = "Display";
                lsKhoa.ValueMember = "Display";
                checkLoadKhoa = true;
                loadLop();
            }
        }
        int khoaSelected=-1;
        private void loadLop()
        {
            if(checkLoadKhoa==true)
            {
                khoaSelected = lsKhoa.SelectedIndex;
                lopBinDing.DataSource = data.lstKhoa[khoaSelected].dsLop;
                lsLop.DataSource = lopBinDing;
                lsLop.DisplayMember = "Display";
                lsLop.ValueMember = "Display";
                checkLoadLop = true;
                loadSV();
            }
        }

        private void loadSV()
        {
            if(checkLoadKhoa==true && checkLoadLop==true)
            {
                int lopSelected = lsLop.SelectedIndex;
                svBinDing.DataSource = data.lstKhoa[khoaSelected].dsLop[lopSelected].dsSinhVien;
                lsSV.DataSource = svBinDing;
                lsSV.DisplayMember = "Display";
                lsSV.ValueMember = "Display";
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            Khoa khoaSelected = (Khoa)lsKhoa.SelectedItem;
            Lop lopThem = new Lop();
            lopThem.MaLop = txtMaLop.Text;
            lopThem.TenLop = txtTenLop.Text;
            lopThem.NamNhapHoc =2020;
            bool checkThemLop = true;
            foreach(Lop data in khoaSelected.dsLop)
            {
                if(lopThem.MaLop.Equals(data.MaLop)||lopThem.TenLop.Equals(data.TenLop))
                {
                    checkThemLop = false;
                    break;
                }
            }
            if(checkThemLop==true)
            khoaSelected.dsLop.Add(lopThem);
            lopBinDing.ResetBindings(false);

        }

        private void lsKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            khoaSelected = lsKhoa.SelectedIndex;
            lopBinDing.DataSource = data.lstKhoa[khoaSelected].dsLop;
            lopBinDing.ResetBindings(false);
        }

        private void lsLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lopSelected = lsLop.SelectedIndex;
            if(lopSelected!=-1)
            {
                svBinDing.DataSource = data.lstKhoa[khoaSelected].dsLop[lopSelected].dsSinhVien;
                svBinDing.ResetBindings(false);
            }
        }
    }
}
