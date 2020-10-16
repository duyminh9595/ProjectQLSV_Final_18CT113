using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_Library.model
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string Ten { get; set; }
        public double SDT { get; set; }
        public string DiaChi { get; set; }
        public string MatKhau { get; set; }
        public DateTime NgaySinh { get; set; }
        public string TrangThaiHocXong { get; set; }
        public string GioiTinh { get; set; }
        public string UserName { get; set; }
        public string Display { get { return Ten; } }
    }
}
