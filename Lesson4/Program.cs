using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите первое число");
            //string a = Console.ReadLine();
            //int a1;
            //a1 = Convert.ToInt32(a);
            //Console.WriteLine("Введите второе чиcло");
            //string b = Console.ReadLine();
            //int b1;
            //b1 = Convert.ToInt32(b);
            //Console.WriteLine("Сумма чисел равна: ");
            //Console.WriteLine(a1 + b1);
            //ИЛИ
            string str;
            int a, b;
            Console.WriteLine("Введите первое число");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.WriteLine("Введите второе число");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            int result = a + b;
            Console.WriteLine("Сумма чисел = " + result);
            
        }
    }
}
