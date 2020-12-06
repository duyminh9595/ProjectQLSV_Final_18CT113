using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_Library;
using QLSV_Library.model;
using QLSV_Library.service;
using WindowsFormsApp2.User_UI;

namespace WindowsFormsApp2
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            lblQuenMatKhau.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
        }

        private void lblQuenMatKhau_MouseLeave(object sender, EventArgs e)
        {
            lblQuenMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(95)))), ((int)(((byte)(223)))));
        }

        private void btnShowMK_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btnDangNhap_MouseLeave(object sender, EventArgs e)
        {
            btnDangNhap.ForeColor = System.Drawing.Color.White;
        }

        private void ckbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienMatKhau.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
                txtPass.PasswordChar = '*';
        }
        string[] arr = {"`","~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "{", "[", "}", "]",".","<",">"
                ,",",".","/","?"};
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            foreach(string data in arr)
            {
                if (txtID.Text.Contains(data))
                    MessageBox.Show("Loi");
            }
        }
        bool checkDN = false;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtID.Text)&&!String.IsNullOrEmpty(txtPass.Text))
            {
                if (txtID.Text.ToUpper().Contains("GV"))
                {
                    foreach(GiaoVien gv in LoadExcel.lstGV)
                    {
                        if(gv.MaGV.Equals(txtID.Text))
                        {
                            if (gv.PassWord.Equals(txtPass.Text))
                            {
                                StatusDangNhapcs.user = txtID.Text;
                                StatusDangNhapcs.check = 3;
                                StatusDangNhapcs.pass = txtPass.Text;
                                checkDN = true;
                            }
                            else
                                break;
                        }
                    }
                }
                else if (txtID.Text.Contains("admin"))
                {
                    foreach(Admin a in LoadExcel.lstAdmin)
                    {
                        if(a.UserName.Equals(txtID.Text))
                        {
                            if (a.PassWord.Equals(txtPass.Text))
                            {
                                StatusDangNhapcs.user = txtID.Text;
                                StatusDangNhapcs.check = 4;
                                StatusDangNhapcs.pass = txtPass.Text;
                                checkDN = true;
                            }
                            else
                                break;
                        }
                    }
                }
                else
                {
                    foreach (SinhVien dataSV in LoadExcel.lstSinhVien)
                    {
                        if (txtID.Text.Equals(dataSV.MSSV) && txtPass.Text.Equals(dataSV.MatKhau))
                        {
                            if (dataSV.TrangThaiHocXong.Equals("YES"))
                            {

                                StatusDangNhapcs.user = txtID.Text;
                                StatusDangNhapcs.check = 2;
                            }
                            else
                            {
                                StatusDangNhapcs.user = txtID.Text;
                                StatusDangNhapcs.check = 1;

                            }
                            checkDN = true;
                            break;
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa Nhập Đủ Thông Tin Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(checkDN==false)
            {
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu", "Warning!!!!!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            { 
                if(StatusDangNhapcs.check==4)
                {
                    this.Hide();
                    QLSV_MainForm mainQL = new QLSV_MainForm();
                    mainQL.Show();
                }
                else
                {
                    this.Hide();
                    GiaoDienUser ui = new GiaoDienUser();
                    ui.Show();
                }
            }

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
        }

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            QuenMatKhau ui = new QuenMatKhau();
            ui.ShowDialog();
        }
    }
}
