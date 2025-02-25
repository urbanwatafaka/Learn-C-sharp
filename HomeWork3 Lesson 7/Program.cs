using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа по порядку");
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double sum_result = first + second + third;
            double mnog_result = first * second * third;
            Console.WriteLine("Сумма трех чисел равна " + sum_result);
            Console.WriteLine("Произведение трех чисел равно " + mnog_result);
        }
    }
}
