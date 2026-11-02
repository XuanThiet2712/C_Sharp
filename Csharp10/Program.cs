using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap DTB :");
            float DTB = float.Parse(Console.ReadLine());
            string xl = (DTB >= 8 ) ? "Gioi" : (DTB >=6.5) ? "Kha" : (DTB >= 5) ? "Trung binh" : "Yeu";
            Console.WriteLine("Xep loai cua ban la : " + xl);
            Console.ReadLine();
        }
    }
}
