using System;;
namespace HomeWork2_Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите колличество рублей для конвертации в доллары:");
            //int roubles = int.Parse(Console.ReadLine());
            //double dollar = 89.95;
            //double convert = (double)roubles / dollar;
            //Console.WriteLine(convert);
            //Жесткая валюта
            Console.WriteLine("Введите сумму для конвертации");
            int rubles = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите курс доллара");
            double usd = double.Parse(Console.ReadLine());
            Console.WriteLine("Сумма после конвертации составляет: " + rubles / usd);
        }
    }
}
