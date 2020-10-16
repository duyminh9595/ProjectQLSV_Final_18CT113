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
            pnData.Controls.Clear();
            Home formHome = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            
            pnData.Controls.Add(formHome);
            formHome.Show();
        }
        private void QLSV_MainForm_Load(object sender, EventArgs e)
        {
           
           DangNhap dnUI = new DangNhap();
           dnUI.ShowDialog();
        }

        private void QLSV_MainForm_Load_1(object sender, EventArgs e)
        {

        }

       
    }
}
