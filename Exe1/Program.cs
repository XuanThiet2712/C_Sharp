using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int a = rd.Next(1, 7);
            Console.WriteLine(a);
            Console.ReadLine();

        }
    }
}
