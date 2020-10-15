using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
