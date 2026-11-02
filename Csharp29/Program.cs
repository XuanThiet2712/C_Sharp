using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp29
{
    class Program
    {
        static void Main(string[] args)
        {
            //dictionary
            Dictionary<string, string> dic1 = new Dictionary<string, string>();
            dic1.Add("user1", "123456");
            dic1.Add("user2", "123456");
            dic1.Add("user3", "123456");
            dic1.Add("user4", "123456");
            dic1.Add("user5", "123456");
            //nhap xu ly
            Console.WriteLine("Nhap username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Nhap password: ");
            string password = Console.ReadLine();
            if (!dic1.ContainsKey(username))
            {
                Console.WriteLine("Username khong ton tai");
            }
            else if (dic1[username] != password)
            {
                Console.WriteLine("Sai password");
            }
            else
            {
                Console.WriteLine("Dang nhap thanh cong");
            }
        }
    }
}
