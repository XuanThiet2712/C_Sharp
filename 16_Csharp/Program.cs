using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số lượng phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            //radom
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rd.Next(1, 100);
            }

            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            // reverse
            Array.Reverse(array);
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Array.Sort(array);
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            int sum = 0;
            foreach (int x in array)
            {
                sum += x;
            }
            Console.WriteLine(sum);
            Console.WriteLine("Nhập số cần tìm: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (array[i] == num)
                {
                    Console.WriteLine("Số " + num + " có trong mảng o vi tri " + (i + 1));
                    break;
                }
                else if(i == n - 1)
                {
                    Console.WriteLine("Số " + num + " không có trong mảng");
                    break;
                }
            }
        }
    }
}
