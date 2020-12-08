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
    public partial class PrintTheReport : Form
    {
        string tl, ml, ms, ss, gv;
        public PrintTheReport(string tenlop,string malop,string mslt,string siso,string gvcn)
        {
            InitializeComponent();
            tl = tenlop;
            ml = malop;
            ms = mslt;
            ss = siso;
            gv = gvcn;
        }

        private void PrintTheReport_Load(object sender, EventArgs e)
        {
            crystalReport22.SetParameterValue(0, tl);
            crystalReport22.SetParameterValue(1, tl);
            crystalReport22.SetParameterValue(2, tl);
            crystalReport22.SetParameterValue(3, tl);
            crystalReport22.SetParameterValue(4, tl);
            crystalReport22.SetParameterValue(5, tl);
        }
    }
}
