using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_28
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ds1 = new List<int>() { 1, 2, 9, 4, 5, 6, };
            int min = ds1.Max();
            int max = ds1.Min();
            int indexMin=0;
            int indexMax=0;
        
            for(int i = 0; i < ds1.Count; i++)
            {
                if (ds1[i] < min && ds1[i] > ds1.Min())
                {
                    min = ds1[i];
                    indexMin = i + 1 ;
                }
                if (ds1[i] > max && ds1[i] < ds1.Max())
                {
                    max = ds1[i];
                    indexMax = i + 1;
                }
            }

            Console.WriteLine("Min: " + min + " Index: " + indexMin);
            Console.WriteLine("Max: " + max + " Index: " + indexMax);
        }
    }
}
