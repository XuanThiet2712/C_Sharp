using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_19
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            Console.WriteLine(str1);
            string[] str2 = str1.Split(' ');
            foreach (string tmp in str2)
            {
                             
                if (char.IsDigit(tmp[0]))
                {
                    sum += Convert.ToDouble(tmp);
                }
            }

            Console.WriteLine(sum / (str2.Length / 3));

        }
    }
}
