using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Поиск среднего арифметического
namespace HomeWork_Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа для нахождения среднего арифметического");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double result = (double)(a + b) / 2;
            Console.WriteLine("Среднее арифметическое = "+result);

        }
    }
}
