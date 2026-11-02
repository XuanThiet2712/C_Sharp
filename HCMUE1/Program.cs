using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace HCMUE1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Moi nhap diem cua ban : ");
            //float diem = float.Parse(Console.ReadLine());

            //if(diem > 9)
            //{
            //    Console.WriteLine("Ban duoc thay Nhan thuong 500k VND");
            //}
            //else if(diem > 8)
            //{
            //    Console.WriteLine("Ban duoc thay nhan dut tui 300k VND");
            //}
            //else if (diem >= 5.5)
            //{
            //    Console.WriteLine("Qua mon");
            //}
            //else
            //{
            //    Console.WriteLine("Dong tien hoc lai :(( ");
            //}

            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Hu tieu");
                    break;
                case 2:
                    Console.WriteLine("My y");
                    break;
                case 3:
                    Console.WriteLine("Banh bao");
                    break;
                default:
                    Console.WriteLine("ko co lua chon");
                    break;
            }
        }
    }
}
