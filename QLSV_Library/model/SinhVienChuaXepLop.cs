using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_Library.model
{
    public class SinhVienChuaXepLop
    {
        public List<SinhVien> dsSVChuaXepLop { get; set; }
        public SinhVienChuaXepLop()
        {
            dsSVChuaXepLop = new List<SinhVien>();
        }
    }
}
