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
    public partial class DoiMatKhauGV : Form
    {
        public DoiMatKhauGV()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtConfirm.Text) && !String.IsNullOrEmpty(txtNewPass.Text) && !String.IsNullOrEmpty(txtOlddPass.Text) && !String.IsNullOrEmpty(lblma.Text))
            {
                foreach(GiaoVien gv in LoadExcel.lstGV)
                {
                    if(gv.MaGV.Equals(txtMSGV.Text.ToUpper()))
                    {
                        if(txtOlddPass.Text.Equals(gv.PassWord))
                        {
                            if (txtConfirm.Text.Equals(txtNewPass.Text))
                            {
                                gv.PassWord = txtConfirm.Text;
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
                MessageBox.Show("Chưa Nhập Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
