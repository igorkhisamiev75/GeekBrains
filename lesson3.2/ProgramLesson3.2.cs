using System;

namespace lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] telephoneBook = new string[5, 2] { 

                { "Geek ", "11-45-52/mail@mail.ru" }, 
                { "Brains ", "22-45-52/mail@mail.ru" }, 
                { "Igor ", "33-45-52/mail@mail.ru" }, 
                { "Andre ", "44-45-52/mail@mail.ru" },
                { "Rodion ", "55-45-52/mail@mail.ru" } 
            };

            for (int i = 0; i < telephoneBook.GetLength(0); i++)
            {
                for (int j=0; j<telephoneBook.GetLength(1);j++)
                {
                    Console.Write($"{telephoneBook[i,j]}");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
