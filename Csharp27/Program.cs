using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rd = new Random();
            List <int> ds1 = new List<int>();
            List <int> ds2 = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(0, 11);
                ds1.Add(x);
            }
            foreach (int i in ds1)
            {
                Console.Write(i + " ");
            }
                Console.WriteLine();
            for (int i = 0; i < ds1.Count; i++)
            {
                if(ds1[i] < 5)
                {
                    Console.Write(ds1[i] + " ");
                    ds2.Add(i);                   
                }
            }
            Console.WriteLine();
            foreach (int i in ds2)
            {
                Console.Write(i + " ");
            }

        }
    }
}
