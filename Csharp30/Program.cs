using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp30
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //            Dictionary<string, int> dic = new Dictionary<string, int>() { { "A", 1 }, { "B", 2 }, { "C", 3 }, { "D", 2 }, { "E", 1 }, { "F", 4 }, { "G", 2 }, { "H", 4 }, { "I", 1 }, { "J", 8 }, { "K", 5 }, { "L", 1 }, { "M", 3 }, { "N", 1 }, { "O", 1 }, { "P", 3 }, { "Q", 10 }, { "R", 1 }, { "S", 1 }, { "T", 1 }, { "U", 1 }, { "V", 4 }, { "W", 4 }, { "X", 8 }, { "Y", 4 }, { "Z", 10 } };

            //            1: Tách số và chữ, hiển thị lên màn hình
            //              2: tính tổng các số
            //          3: chuyển đổi chuỗi: "University of Technology and Education" sang số

            Dictionary<string, int> dic = new Dictionary<string, int>() { { "A", 1 }, { "B", 2 }, { "C", 3 }, { "D", 2 }, { "E", 1 }, { "F", 4 }, { "G", 2 }, { "H", 4 }, { "I", 1 }, { "J", 8 }, { "K", 5 }, { "L", 1 }, { "M", 3 }, { "N", 1 }, { "O", 1 }, { "P", 3 }, { "Q", 10 }, { "R", 1 }, { "S", 1 }, { "T", 1 }, { "U", 1 }, { "V", 4 }, { "W", 4 }, { "X", 8 }, { "Y", 4 }, { "Z", 10 } };
            Console.WriteLine("chuoi ky tu sau tach la: ");
            foreach (KeyValuePair<string, int> kvp in dic)
            {
                Console.Write(kvp.Key + " ");
            }
            Console.WriteLine();
            Console.Write("chuoi so sau tach la: ");
            int sum = dic.Values.Sum();
            foreach (KeyValuePair<string, int> kvp in dic)
            {
                Console.Write(kvp.Value + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Tong cac so la: " + sum);
            string s = "University of Technology and Education";
            Console.WriteLine(s);
            foreach (char c in s) {
                if (c == ' ')
                    Console.Write(" ");
                else
                {
                    Console.Write(dic[c.ToString().ToUpper()]);
                }

            }
        }
    } }
