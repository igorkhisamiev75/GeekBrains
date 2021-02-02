using System;

namespace lesson4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа для получения суммы этих чисел:");
            string str = Console.ReadLine();

            string[] num = str.Split(' ');
            int i = 1;

            foreach (var num1 in num)
            {
               Console.WriteLine($"{i} число =  {num1} ");
                i ++;
            }

            int sum = 0;
            i = i - 1;

            for (int j=0; j<i; j++)
            {
                sum = sum + Convert.ToInt32(num[j]);
            }


            Console.WriteLine($"Сумма чисел равна {sum}");
            Console.ReadLine();

        }
    }
}
