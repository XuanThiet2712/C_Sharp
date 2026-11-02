using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1000; 

            for(int a = 1; a <= k; a++)
            {
                int uoc = 0;
                for (int i = 1; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        uoc += i;
                    }
                }
                if (a == uoc )
                    Console.WriteLine(a + " la so hoan hao");
            }
          
  

            Console.ReadLine();
        }
    }
}
