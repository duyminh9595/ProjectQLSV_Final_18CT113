using QLSV_Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_Library.service
{
    public static class CheckTrungEmail
    {
        public static bool check(List<SinhVien>lstSV,List<Admin>lstAdmin,List<GiaoVien>lstGV,string email)
        {
            foreach(SinhVien sv in lstSV)
            {
                if (sv.UserName.Equals(email))
                    return false;
            }
            foreach(GiaoVien gv in lstGV)
            {
                if (gv.Email.Equals(email))
                    return false;
            }
            foreach(Admin a in lstAdmin)
            {
                if (a.Email.Equals(email))
                    return false;
            }
            return true;
        }
    }
}
