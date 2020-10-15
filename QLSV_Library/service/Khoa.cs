using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_Library.model
{
    public class Khoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public List<Lop> dsLop { get; set; }
        public string Display { get { return TenKhoa; } }
        public Khoa()
        {
            dsLop = new List<Lop>();
        }
    }

}
