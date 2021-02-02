using System;

namespace lesson3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер поля:");
            int i = Convert.ToInt32(Console.ReadLine());

            
            int j = i;

            string[,] array = new string[i, j]; //создаем новый массив размерностью i и j

            

            for (int x = 0; x < i; x++)
            {
                for (int y = 0; y < j; y++)
                {
                    array[x, y] = "0";

                }

            }
            Console.ForegroundColor = ConsoleColor.Green;

            //рисуем первый корабль 
            array[1, 1] = "x";
            array[1, 2] = "x";
            array[1, 3] = "x";

            //рисуем второй корабль
            array[5, 5] = "x";
            array[5, 6] = "x";
            array[5, 7] = "x";

            //рисуем третий корабль 
            array[7, 9] = "x";
            array[8, 9] = "x";
            array[9, 9] = "x";

            int iMax = i;
            int jMax = j;

            //вывод его
            for (j = 0; j < jMax; j++)
            {
                for (i = 0; i < iMax; i++)
                {
                    Console.Write($"{array[i, j] }" + " ");
                }

                Console.WriteLine("\b");

            }

            Console.ForegroundColor = ConsoleColor.DarkGray;

        }
    }
}
