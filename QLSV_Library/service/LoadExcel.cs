using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using QLSV_Library.model;
using System.Net.Http;

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
        public static List<Lop> lstLop;
        public static List<SinhVien> lstSinhVien;
        public static List<NamHoc> lstNam;
        static LoadExcel()
        {
            wb = excel.Workbooks.Open(AppDomain.CurrentDomain.BaseDirectory+path);
            lstKhoa = new List<Khoa>();
            lstLop = new List<Lop>();
            lstSinhVien = new List<SinhVien>();
            svChuaXepLop = new SinhVienChuaXepLop();
            lstNam = new List<NamHoc>();
            ReadKhoa(0, 0);
            ReadLop(0, 0);
            ReadSinhVien(0);
            ReadNam(0);
            excel.Quit();
        }

        private static void ReadNam(int i)
        {
            ws = wb.Worksheets[4];
            i++;
            while (ws.Cells[i, 1].Value != null)
            {
                NamHoc nam = new NamHoc();
                nam.Nam= ws.Cells[i, 1].Value;
                nam.SL = ws.Cells[i, 2].Value;
                lstNam.Add(nam);
                ++i;
            }
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
                        lop.khoa = data;
                        lstLop.Add(lop);
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
                    if (ws.Cells[i, 10].Value != null)
                        s = ws.Cells[i, 10].Value;
                    double mssv = ws.Cells[i, 1].Value;
                    sv.MSSV = mssv.ToString();
                    sv.Ten = ws.Cells[i, 2].Value;
                    sv.SDT = ws.Cells[i, 3].Value;
                    sv.DiaChi = ws.Cells[i, 4].Value.ToString();
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
                                foreach (Lop dataLop in lstLop)
                                {
                                    if (dataLop.MaLop.Equals(tenlop))
                                    {
                                        dataLop.dsSinhVien.Add(sv);
                                        sv.lop =dataLop;
                                        lstSinhVien.Add(sv);
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
                        lstSinhVien.Add(sv);
                    }
                    
                        
                    ++i;
                }
            
        }
        public static void saveExcel()
        {
            wb.Save();
            
            wb.Close();
        }
        public static void writeExcel()
        {
            writeLop();
            writeKhoa();
            writeSinhVien();
            writeNam();
        }

        private static void writeNam()
        {
            ws = wb.Worksheets[4];
            ws.Cells.ClearContents();
            int i = 1;
            int j = 0;
            foreach (NamHoc nam in lstNam)
            {
                j = 1;
                ws.Cells[i, j++].Value = nam.Nam;
                ws.Cells[i, j].Value = nam.SL;
                ++i;
            }
        }

        private static void writeLop()
        {
            ws = wb.Worksheets[2];
            ws.Cells.ClearContents();
            int i = 1;
            int j = 0;
            foreach(Lop dataLop in lstLop)
            {
                j = 1;
                ws.Cells[i, j++].Value = dataLop.NamNhapHoc;
                ws.Cells[i, j++].Value = dataLop.MaLop;
                ws.Cells[i, j++].Value = dataLop.TenLop;
                ws.Cells[i, j++].Value = dataLop.khoa.MaKhoa;
                ++i;
            }
        }

        private static void writeSinhVien()
        {
            ws = wb.Worksheets[3];
            ws.Cells.ClearContents();
            int i = 1;
            int j = 0;
            foreach (SinhVien dataSinhVien in lstSinhVien)
            {
                j = 1;
                ws.Cells[i, j++].Value = dataSinhVien.MSSV.ToString();
                ws.Cells[i, j++].Value = dataSinhVien.Ten;
                ws.Cells[i, j++].Value = dataSinhVien.SDT.ToString();
                ws.Cells[i, j++].Value = dataSinhVien.DiaChi;
                ws.Cells[i, j++].Value = dataSinhVien.MatKhau;
                ws.Cells[i, j++].Value = dataSinhVien.NgaySinh;
                ws.Cells[i, j++].Value = dataSinhVien.TrangThaiHocXong;
                ws.Cells[i, j++].Value = dataSinhVien.GioiTinh;
                ws.Cells[i, j++].Value = dataSinhVien.UserName;
                if(dataSinhVien.lop!=null)
                    ws.Cells[i, j++].Value = dataSinhVien.lop.MaLop; 
                ++i;
                    
            }
        }

        private static void writeKhoa()
        {
            ws = wb.Worksheets[1];
            ws.Cells.ClearContents();
            int i = 1;
            int j = 0;
            foreach (Khoa data in lstKhoa)
            {
                j = 1;
                ws.Cells[i, j++].Value = data.MaKhoa;
                ws.Cells[i, j].Value = data.TenKhoa;
                ++i;
            }
        }
        public static void exitUI()
        {
            wb = excel.Workbooks.Open(AppDomain.CurrentDomain.BaseDirectory + path);
            writeExcel();
            saveExcel();
            excel.Quit();
        }
    }
}
