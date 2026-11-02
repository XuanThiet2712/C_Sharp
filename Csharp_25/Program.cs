using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_25
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ds1 = new List<int>();
            Console.WriteLine("Nhap so phan tu cua danh sach: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                int x = int.Parse(Console.ReadLine());
                ds1.Add(x);
            }
            foreach (int x in ds1)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            List<int> ds2 = new List<int>();
            int count = 0; 
            foreach (int i in ds1)
            {
                ds2.Add(i * i);
                if (i * i > 50) count++;
            }
            Console.WriteLine("Danh sach ds2: ");
            foreach (int x in ds2)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine(count + " phan tu trong ds2 lon hon 50");
            Console.WriteLine();
            //

        }
    }
}
