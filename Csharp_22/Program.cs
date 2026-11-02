using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string a = " tôi chăm học  tôi chịu khó tôi đẹp zai ";
            string[] str = a.Split(' ');
            int count = 0; 
            foreach (string str2 in str) 
                {
                    if(str2.Equals("tôi"))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
