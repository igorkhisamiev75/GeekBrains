using System;

namespace lesson3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();

            int n = word.Length;

            do
            {
                Console.Write(word[n - 1]);
                n--;
            } while (n != 0);

            Console.ReadLine();

        }
    }
}
