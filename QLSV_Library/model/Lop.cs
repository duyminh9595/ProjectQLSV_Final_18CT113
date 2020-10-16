﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_Library.model
{
    public class Lop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public double NamNhapHoc { get; set; }
        public List<SinhVien> dsSinhVien { get; set; }
        public string Display { get { return TenLop; } }
        public Lop()
        {
            dsSinhVien = new List<SinhVien>();
        }
    }
}