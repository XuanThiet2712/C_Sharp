using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPC_
{
    class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTrungBinh { get; set; }
        //constructor
        public SinhVien()
        {
            MaSV = "";
            HoTen = "";
            DiemTrungBinh = 0;
        }
        public SinhVien(string maSV, string hoTen, double diemTrungBinh)
        {
            MaSV = maSV;
            HoTen = hoTen;
            DiemTrungBinh = diemTrungBinh;
        }

        public string XepLoai()
        {
            if(DiemTrungBinh >= 9)
                return "Xuất sắc";
            else if (DiemTrungBinh >= 8)
                return "Giỏi";
            else if (DiemTrungBinh >= 6.5)
                return "Khá";
            else if (DiemTrungBinh >= 5)
                return "Trung bình";
            else
                return "Yếu";
        }
    }
}
