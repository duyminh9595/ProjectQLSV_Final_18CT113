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

        private void Home_Load(object sender, EventArgs e)
        {
            int dem = 0;
            int nam = 0, nu = 0;
            foreach(Khoa data in LoadExcel.lstKhoa)
            {
                dem = 0;
                foreach(Lop dataLop in data.dsLop)
                {
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
                        }
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
        }
    }
}
