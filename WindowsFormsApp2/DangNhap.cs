﻿using System;
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
            foreach(Khoa data in LoadExcel.lstKhoa)
            {
                foreach(Lop dataLop in data.dsLop)
                {
                    foreach(SinhVien dataSV in dataLop.dsSinhVien)
                    {
                        if (txtID.Text.Equals(dataSV.UserName) && txtPass.Text.Equals(dataSV.MatKhau))
                        {
                            this.Hide();
                            QLSV_MainForm mainQL = new QLSV_MainForm();
                            mainQL.Show();
                            checkDN = true;
                        }
                    }
                }
            }
            if(checkDN==false)
            {
                MessageBox.Show("Loi", "Ngu vl");
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            label3.Text=label3.Text.ToUpper();
        }
    }
}
