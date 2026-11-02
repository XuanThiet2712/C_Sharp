using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_App
{
    class Nguoi
    {
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }

        //constructor
        public Nguoi(string hoTen, string gioiTinh, DateTime ngaySinh)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
        }
        public Nguoi() { }

        public void LayThongTin()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Gioi tinh: " + gioiTinh);
            Console.WriteLine("Ngay sinh: " + ngaySinh.ToShortDateString());
        }   
    }
}
