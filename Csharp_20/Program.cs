using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string passLogin = "aaaaaAAAAAA1";
            string input;
            int k = 5;
            while (true)
            {
                Console.WriteLine("Moi ban nhap pass Login :");
                input = Console.ReadLine();
                if (input.Length < 6)
                {
                    Console.WriteLine(input + " khong hop le, do dai mat khau phai lon hon 6 ky tu");
                    continue;
                }
                bool checkDigit = false;
                foreach (char c in input)
                {
                    if (char.IsDigit(c))
                    {
                        checkDigit = true;
                        break;
                    }
                }
                if (!checkDigit)
                {
                    Console.WriteLine(input + " khong hop le, mat khau phai chua it nhat 1 chu so");
                }
                else
                {
                    Console.WriteLine("Ban da nhap pass hop le");
                    break;
                }
            }

            // nhap passs

            // passlogin
            for (int i = 1; i <= k; i++)
            {
                {
                    Console.WriteLine("Nhap passLogin :");
                    passLogin = Console.ReadLine();
                    if (passLogin.Equals(input))
                    {
                        Console.WriteLine("Dang nhap thanh cong");
                        break;
                    }
                    else if (i == 5)
                    {
                        Console.WriteLine("Tai khoan cua ban da bi khoa vinh vien");
                    }
                    else
                    {
                        Console.WriteLine("Sai passLogin, ban con {0} lan nhap", k - i);
                    }


                }

            }
        }
    }
}
