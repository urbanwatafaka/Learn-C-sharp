using System;


//Ввод данных в консоль

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявляем переменную
            string data;
            //Инициализируем переменную, путем ввода через консоль
            data = Console.ReadLine();
            //Выводим приветствие + значение переменной полученное в консоли при вводе
            Console.WriteLine("Привет " + data);
            Console.ReadKey();
        }
    }
}
