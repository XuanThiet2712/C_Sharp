using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_App
{
    class SinhVien : Nguoi
    {
        public string maSV { get; set; }
        public string maLop { get; set; }
        public double diemTB { get; set; }

        //constructor
        public SinhVien(string hoTen, string gioiTinh, DateTime ngaySinh, string maSV, string maLop, double diemTB) : base(hoTen, gioiTinh, ngaySinh)
        {
            this.maSV = maSV;
            this.maLop = maLop;
            this.diemTB = diemTB;
        }
        public string XepLoai()
        {
            if (diemTB >= 8)
                return "Gioi";
            else if (diemTB >= 6.5)
                return "Kha";
            else if (diemTB >= 5)
                return "Trung binh";
            else
                return "Yeu";
        }




    }
}
