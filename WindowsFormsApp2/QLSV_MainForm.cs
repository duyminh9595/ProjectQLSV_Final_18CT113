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

namespace WindowsFormsApp2
{
    public partial class QLSV_MainForm : Form
    {
        public QLSV_MainForm()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
        }
        private void QLSV_MainForm_Load(object sender, EventArgs e)
        {
           
           DangNhap dnUI = new DangNhap();
           dnUI.ShowDialog();
        }

        
        private void ckbHome_Click_1(object sender, EventArgs e)
        {
            if (ckbHome.Checked)
            {
                ckbHome.BackColor = System.Drawing.Color.White;
                pnData.Controls.Clear();
                Home formHome = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                formHome.FormBorderStyle = FormBorderStyle.None;
                pnData.Controls.Add(formHome);
                formHome.Show();
            }
            else
            {
                pnData.Controls.Clear();
            }
        }
    }
}
