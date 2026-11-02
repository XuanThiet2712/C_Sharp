using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_24
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ds1 = new List<int>();
            int n; 
            Console.WriteLine("Nhap so phan tu cua danh sach: ");
            n = int.Parse(Console.ReadLine());
            Random rd = new Random();

            for (int i = 0; i < n; i++)
            {
                ds1.Add(rd.Next(1, 100));
            }

            foreach (int i in ds1)
            {
                Console.Write(i + " ");
            }
            }
    }
}
