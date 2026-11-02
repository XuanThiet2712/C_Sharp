using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien sv1 = new SinhVien();
            sv1.MaSV = "SV001";
            sv1.HoTen = "Nguyen Van A";
            sv1.DiemTrungBinh = 8.5;

            Console.WriteLine("Mã sinh viên: " + sv1.MaSV);
            Console.WriteLine("Họ tên: " + sv1.HoTen);
            Console.WriteLine("Điểm trung bình: " + sv1.DiemTrungBinh);
            Console.WriteLine("Xếp loại: " + sv1.XepLoai());
        }
    }
}
