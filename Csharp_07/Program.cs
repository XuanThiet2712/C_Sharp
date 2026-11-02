using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap thang : ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1: 
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang {0} co 31 ngay", month);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang {0} co 30 ngay", month);
                    break;
                case 2:
                    Console.WriteLine("Moi ban nhap nam : ");
                    int year = int.Parse(Console.ReadLine());
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        Console.WriteLine("Thang {0} co 29 ngay", month);
                    }
                    else
                    {
                        Console.WriteLine("Thang {0} co 28 ngay", month);
                    }
                    break;
            }
        }
    }
}
