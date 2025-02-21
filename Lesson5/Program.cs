using System;
using System.Globalization;

/* Конвертация, если региональные настройки устройств отличаются. 
Например: дробное число через ТОЧКУ (1.9), а не запятую (1,9)
*/

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1.9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double a = Convert.ToDouble(str, numberFormatInfo);
            Console.WriteLine(a);
        }
    }
}
