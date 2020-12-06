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

namespace WindowsFormsApp2.User_UI
{
    public partial class ThongTinGiaoVien_User : Form
    {
        public ThongTinGiaoVien_User()
        {
            InitializeComponent();
        }

        private void ThongTinGiaoVien_User_Load(object sender, EventArgs e)
        {
            lblMSSV.Text = "Mã Số Giáo Viên " + StatusDangNhapcs.user;
            foreach(GiaoVien gv in LoadExcel.lstGV)
            {
                if(gv.MaGV.Equals(StatusDangNhapcs.user))
                {
                    txtTen.Text = gv.TenGV;
                    txtEmail.Text = gv.Email;
                    txtMK.Text = gv.PassWord;
                    break;
                }
            }
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
