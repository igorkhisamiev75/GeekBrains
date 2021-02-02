using System;

namespace lesson4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер последовательности Фибоначи:");
            int n = Convert.ToInt32(Console.ReadLine());

            static int Fibonachi(int n)
            {
                if (n == 0 || n == 1)
                {
                    return n;
                }
                else
                {
                    return Fibonachi(n - 1) + Fibonachi(n - 2);
                }
            }

            Console.WriteLine($"Фибоеаччи {n} = {Fibonachi(n)}");
            Console.ReadKey();

        }
    }
}
