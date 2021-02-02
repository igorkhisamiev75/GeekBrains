using System;

namespace lesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int num = Convert.ToInt32(Console.ReadLine());

            if((num%2)==1)
            {
                Console.WriteLine($"{num} - это нечетное число");
            }
            else
            {
                Console.WriteLine($"{num} - это четное число");
            }

            Console.ReadKey();
        }
    }
}
