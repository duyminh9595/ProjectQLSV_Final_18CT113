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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtConfirm.Text)&& !String.IsNullOrEmpty(txtNewPass.Text)&& !String.IsNullOrEmpty(txtOlddPass.Text))
            {
                if(txtOlddPass.Text.Equals(StatusDangNhapcs.pass))
                {
                        foreach (Admin a in LoadExcel.lstAdmin)
                        {
                            if (a.UserName.Equals(StatusDangNhapcs.user))
                            {
                                if (txtOlddPass.Text.Equals(a.PassWord))
                                {
                                    if (txtConfirm.Text.Equals(txtNewPass.Text))
                                    {
                                        a.PassWord = txtConfirm.Text;
                                        MessageBox.Show("Đổi Mật Khẩu Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                        MessageBox.Show("Mật Khẩu Mới Và Xác Nhận Không Giống Nhau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("Nhập Sai Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    
                   
                }
                else
                {
                    MessageBox.Show("Nhập Sai Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa Nhập Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            if(StatusDangNhapcs.check==3)
            {
                lblTitle.Text = "Đổi Mật Khẩu Giáo Viên " + StatusDangNhapcs.user;
            }
            else
            {
                lblTitle.Text = "Đổi Mật Khẩu Sinh Viên " + StatusDangNhapcs.user;
            }
        }
    }
}
