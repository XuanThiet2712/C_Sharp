using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Csharp05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao chieu cao (m):");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao can nang (kg):");
            float w = float.Parse(Console.ReadLine());
            double BMI = w / Math.Pow(h, 2);
            Console.WriteLine("Chi so BMI cua ban la: " + BMI);
            if (BMI < 15)
            {
                Console.WriteLine("Than hinh qua gay");
            }
            else if (BMI < 16)
            {
                Console.WriteLine("Than hinh gay");
            }
            else if (BMI < 18.5)
            {
                Console.WriteLine("Than hinh hoi gay");
            }
            else if (BMI < 25)
                Console.WriteLine("Than hinh binh thuong");
            else if (BMI < 30)
                Console.WriteLine("Than hinh hoi beo");
            else if (BMI < 35)
                Console.WriteLine("Than hinh beo");
            else
                Console.WriteLine("Than hinh qua beo");

            Console.ReadKey();
        }

    }
}
