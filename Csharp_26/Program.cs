using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quest = new List<string>() { "2 + 5 + 7 = ", "5 * 10 =","sqrt(16)", "12%2=", "5//2=" };
            List<string> ans = new List<string>() { "14", "50", "4", "0", "2" };
            foreach (string q in quest)
            {
                Console.WriteLine(q);
                string userAns = Console.ReadLine();
                if (userAns == ans[quest.IndexOf(q)])
                {
                    Console.WriteLine("Dung");
                }
                else
                {
                    Console.WriteLine("Sai");
                }
            }

        }
    }
}
