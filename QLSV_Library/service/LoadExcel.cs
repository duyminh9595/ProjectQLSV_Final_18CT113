using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using QLSV_Library.model;

namespace QLSV_Library.service
{
    public static class LoadExcel
    {
        static string path = @"Database.xlsx";
        static _Application excel = new _Excel.Application();
        static Workbook wb;
        static Worksheet ws;
        static Worksheet ws1;
        public static SinhVienChuaXepLop svChuaXepLop;
        public static List<Khoa> lstKhoa;
        static LoadExcel()
        {
            wb = excel.Workbooks.Open(AppDomain.CurrentDomain.BaseDirectory+path);
            lstKhoa = new List<Khoa>();
            svChuaXepLop = new SinhVienChuaXepLop();
            ReadKhoa(0, 0);
            ReadLop(0, 0);
            ReadSinhVien(0);
            excel.Quit();
        }
        public static void ReadKhoa(int i,int j)
        {
            ws = wb.Worksheets[1];
            i++;
            j++;
            while(ws.Cells[i,j].Value!=null)
            {
                Khoa khoa = new Khoa();
                khoa.MaKhoa = ws.Cells[i, 1].Value;
                khoa.TenKhoa = ws.Cells[i, 2].Value;
                lstKhoa.Add(khoa);
                ++i;
            }
        }
        public static void ReadLop(int i, int j)
        {
            ws1 = wb.Worksheets[2];
            i++;
            j++;
            while (ws1.Cells[i, j].Value != null)
            {
                string s = "";
                s= ws1.Cells[i, 2].Value;
                string maKhoa = s[2].ToString() + s[3].ToString();
                foreach(Khoa data in lstKhoa)
                {
                    if(maKhoa.Equals(data.MaKhoa))
                    {
                        Lop lop = new Lop();
                        lop.MaLop = s;
                        lop.TenLop = ws1.Cells[i, 3].Value;
                        lop.NamNhapHoc = ws1.Cells[i, 1].Value;
                        data.dsLop.Add(lop);
                        break;
                    }
                }
                ++i;
            }
        }
        public static void ReadSinhVien(int i)
        {
            ws = wb.Worksheets[3];
            i++;
            
                while (ws.Cells[i, 2].Value != null)
                {
                    SinhVien sv = new SinhVien();
                    string s = "";
                    if (ws.Cells[i, 1].Value != null)
                        s = ws.Cells[i, 1].Value;
                    sv.MSSV = s;
                    sv.Ten = ws.Cells[i, 2].Value;
                    sv.SDT = ws.Cells[i, 3].Value;
                    sv.DiaChi = ws.Cells[i, 4].Value;
                    sv.MatKhau = ws.Cells[i, 5].Value;
                    sv.NgaySinh = ws.Cells[i, 6].Value;
                    sv.TrangThaiHocXong = ws.Cells[i, 7].Value;
                    sv.GioiTinh=ws.Cells[i, 8].Value;
                    sv.UserName = ws.Cells[i, 9].Value;
                    if(!String.IsNullOrEmpty(s))
                    {
                        string maKhoa = s[2].ToString() + s[3].ToString();
                        string tenlop = s[0].ToString() + s[1].ToString() + s[2].ToString() + s[3].ToString() + s[4].ToString();
                        bool themSV = false;
                        foreach (Khoa dataKhoa in lstKhoa)
                        {
                            if (dataKhoa.MaKhoa.Equals(maKhoa))
                            {
                                foreach (Lop dataLop in dataKhoa.dsLop)
                                {
                                    if (dataLop.MaLop.Equals(tenlop))
                                    {
                                        dataLop.dsSinhVien.Add(sv);
                                        themSV = true;
                                        break;
                                    }
                                }
                                if (themSV == true)
                                    break;
                            }
                        }
                    }
                    else
                    {
                        svChuaXepLop.dsSVChuaXepLop.Add(sv);
                    }
                    
                        
                    ++i;
                }
            
        }
    }
}
