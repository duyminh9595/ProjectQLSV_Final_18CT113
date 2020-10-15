using QLSV_Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_Library
{
    public class FakeDatabase
    {
        public List<Khoa> dsKhoa;
        public FakeDatabase()
        {
            dsKhoa = new List<Khoa>();
        }
    }
}
