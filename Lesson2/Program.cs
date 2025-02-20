using System;
using System.ComponentModel.Design.Serialization;
/* Переменыне в C#
 * 1. Объявление (создание) переменной
 * 2. Инициализация переменной
 * 3. Присвоение значение переменной
*/

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявляем переменную: Тип_данных имя_переменной
            int a, b;

            //Инициализация переменной: к переменной присваиваем значение (a = 1)
            a = 10;
            b = 5;
            Console.WriteLine(a + b);

            //Так же можно инициализировать переменную во время ее создания;
            //int a = 10;

            //Console.WriteLine(a);
        }
    }
}
