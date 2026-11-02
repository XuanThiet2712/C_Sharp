using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b = "zxcvbnmasdfghjklqwertyuiop" ;

            string input = Console.ReadLine();
            string tmp = "";
            for (int i = 0; i < input.Length; i++)  
            {
                int index = a.IndexOf(input[i]);

                tmp += (index != -1 ? b[index] : input[i]);
            }

            Console.WriteLine(tmp);
        }
    }
}
