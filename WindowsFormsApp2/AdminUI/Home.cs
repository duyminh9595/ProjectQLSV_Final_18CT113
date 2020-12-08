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

namespace WindowsFormsApp2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }
        int slsvconhoc = 0, slsvchuaxeplop = 0;
        private void Home_Load(object sender, EventArgs e)
        {
            int dem = 0;
            int nam = 0, nu = 0;
            int namBefore1 = 0, namBefore2 = 0, namBefore3 = 0, namBefore4 = 0,namBefore0=0;
            int namhientai = DateTime.Now.Year;
            int svTinhDongNai = 0, svTinhKhac = 0;
            lblChuaXepLop.Text = "0";
            lblSVConHoc.Text = "0";
            
            foreach(Khoa data in LoadExcel.lstKhoa)
            {
                dem = 0;
                foreach(Lop dataLop in data.dsLop)
                {
                    int temp = 0;
                    foreach(SinhVien dataSV in dataLop.dsSinhVien)
                    {
                        if(dataSV.GioiTinh.Equals("NAM"))
                        {
                            ++nam;
                        }
                        if (dataSV.GioiTinh.Equals("NU"))
                        {
                            ++nu;
                        }
                        if(dataSV.TrangThaiHocXong.Equals("NO"))
                        {
                            ++dem;
                            ++slsvconhoc;
                        }
                        if(dataSV.DiaChi.Contains("Đồng Nai"))
                        {
                            ++svTinhDongNai;
                        }
                        if (!dataSV.DiaChi.Contains("Đồng Nai"))
                        {
                            ++svTinhKhac;
                        }
                        ++temp;
                    }

                    if (dataLop.NamNhapHoc ==namhientai)
                    {
                        namBefore0 += temp;
                    }
                    if (dataLop.NamNhapHoc == namhientai-1)
                    {
                        namBefore1 += temp;
                    }
                    if (dataLop.NamNhapHoc == namhientai-2)
                    {
                        namBefore2 += temp;
                    }
                    if (dataLop.NamNhapHoc == namhientai-3)
                    {
                        namBefore3 += temp;
                    }
                    if (dataLop.NamNhapHoc == namhientai-4)
                    {
                        namBefore4 += temp;
                    }
                }
                if(dem!=0)
                    chartSLSV.Series["Series1"].Points.AddXY(data.TenKhoa, dem.ToString());
            }
            if(nam!=0)
            {
                chartSVTheoGioiTinh.Series["Series1"].Points.AddXY("Nam", nam.ToString());
            }
            if(nu!=0)
            {
                chartSVTheoGioiTinh.Series["Series1"].Points.AddXY("Nữ", nu.ToString());
            }
            charSVTheoNam.Series["SLSV"].Points.AddXY("Năm " + namhientai.ToString() , namBefore0.ToString());
            charSVTheoNam.Series["SLSV"].Points.AddXY("Năm " + (namhientai-1).ToString() , namBefore1.ToString());
            charSVTheoNam.Series["SLSV"].Points.AddXY("Năm " + (namhientai - 2).ToString() , namBefore2.ToString());
            charSVTheoNam.Series["SLSV"].Points.AddXY("Năm " + (namhientai - 3).ToString() , namBefore3.ToString());
            charSVTheoNam.Series["SLSV"].Points.AddXY("Năm " + (namhientai - 4).ToString() , namBefore4.ToString());
            if(svTinhKhac!=0)
            {
                chartSVTinhThanh.Series["Series1"].Points.AddXY("Ngoại Tỉnh", svTinhKhac.ToString());
            }
            if(svTinhDongNai!=0)
            {
                chartSVTinhThanh.Series["Series1"].Points.AddXY("Tỉnh Đồng Nai", svTinhDongNai.ToString());
            }
            lblSVConHoc.Text = slsvconhoc.ToString();
            lblChuaXepLop.Text = LoadExcel.svChuaXepLop.dsSVChuaXepLop.Count().ToString();
        }
    }
}
