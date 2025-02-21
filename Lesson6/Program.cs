using System;
using System.Globalization;

//Конвертация строки;
//parse и tryparse

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "0.9";
            //int a = int.Parse(str);
            //Console.WriteLine(a);




            //string str = "5,9";
            //NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            //{
            //    NumberDecimalSeparator = ".",
            //};
            //double a = double.Parse(str, numberFormatInfo);
            //Console.WriteLine(a);


            string str = "1dsf";
            int a;
            bool result = int.TryParse(str, out a);
            Console.WriteLine(result);
            if (result)
            {
                Console.WriteLine("Удалось конвертировать, результат: " + a);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать");
            }
        }
    }
}
