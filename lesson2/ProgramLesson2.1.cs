using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки:");
            double minTemp=Convert.ToDouble(Console.ReadLine().Replace(".",","));

            Console.WriteLine("Введите максимальную температуру за сутки:");
            double maxTemp = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

            double averTemp = (minTemp + maxTemp) / 2;

            Console.WriteLine($"Минимальная температура {minTemp}°C \n" +
                              $"Максимальная температура {maxTemp}°C \n" +
                              $"Средняя за сутки {averTemp}°C");
            Console.ReadLine();

        }
    }
}
