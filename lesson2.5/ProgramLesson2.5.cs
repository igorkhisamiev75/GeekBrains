using System;

namespace lesson2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки:");
            double minTemp = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

            Console.WriteLine("Введите максимальную температуру за сутки:");
            double maxTemp = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            double averTemp = (minTemp + maxTemp) / 2;

            Console.WriteLine("Введите порядковый номер месяца от 1 до 12");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Минимальная температура {minTemp}°C \n" +
                              $"Максимальная температура {maxTemp}°C \n" +
                              $"Средняя за сутки {averTemp}°C\n");

            //проверка условий средней температуры и номера месяца 

            if ((averTemp>0) && (i == 12 || i == 1 || i == 2) ){
                Console.WriteLine("Дождливая зима");
                Console.ReadLine();
            }

            else
            {
                Console.ReadLine();
            }

            

        }
    }
}
