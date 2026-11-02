using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static double TinhTong(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "       ABC Def            ";  
            Console.WriteLine(s);
            Console.WriteLine(s.Length);
            Console.WriteLine(s[s.Length-1]);
            Console.WriteLine(s.Trim());
            Console.WriteLine(s.Trim().Length);
            Console.WriteLine(s.Trim().ToUpper());
            Console.WriteLine(s.Trim().ToLower());
            if(s.Contains("ABC"))
            {
                Console.WriteLine("Chuỗi có chứa ABC");
            }
            else
            {
                Console.WriteLine("Chuỗi không chứa ABC");
            }
            string k = s.Trim();
            Console.WriteLine(k);
        }
    }
}
