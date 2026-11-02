using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp23
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string strSo = "";
            string strChu = "";
            foreach (char c in s)
            {
                if(char.IsDigit(c))
                    { strSo += c; }
                else if(char.IsLetter(c))
                { strChu += c; }

            }
            Console.WriteLine(strSo);
            Console.WriteLine(strChu);
        }
    }
}
