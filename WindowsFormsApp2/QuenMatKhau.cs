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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool doiMK = false;
            if (!String.IsNullOrEmpty(txtID.Text) && !String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtMK.Text))
            {
                if(txtID.Text.Contains("GV"))
                {
                    foreach(GiaoVien gv in LoadExcel.lstGV)
                    {
                        if(gv.MaGV.Equals(txtID.Text))
                        {
                            if(gv.Email.Equals(txtEmail.Text))
                            {
                                gv.PassWord = txtMK.Text;
                                doiMK = true;
                            }
                            break;
                        }
                    }
                }
                else if(txtID.Text.Contains("admin"))
                {
                    foreach(Admin a in LoadExcel.lstAdmin)
                    {
                        if (a.UserName.Equals(txtID.Text))
                        {
                            if (a.Email.Equals(txtEmail.Text))
                            {
                                a.PassWord = txtMK.Text;
                                doiMK = true;
                            }
                            break;
                        }
                    }
                }
                else
                {
                    foreach(SinhVien sv in LoadExcel.lstSinhVien)
                    {
                        if(sv.MSSV.Equals(txtID.Text))
                        {
                            if(sv.UserName.Equals(txtEmail.Text))
                            {
                                sv.MatKhau = txtMK.Text;
                                doiMK = true;
                            }
                            break;
                        }
                    }
                }
                if(doiMK==false)
                    MessageBox.Show("Lấy Lại Mật Khẩu Thất Bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Lấy Lại Mật Khẩu Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadExcel.exitUI();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Chưa Nhập Đủ Thông Tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
