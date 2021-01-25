using System;

namespace lesson3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество столбцов массива:");
            int i = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Введите колличество строк массива:");
            int j = Convert.ToInt32(Console.ReadLine());

            string[,] array=new string[i,j]; //создаем новый массив размерностью i и j

            //создадим значения для массива первый элемент 0.0, второй 0.1 и т.д.
           
            for (int x = 0; x < i; x++)
            {
                for (int y = 0; y < j; y++)
                {
                    array[x, y] = Convert.ToString(x)+"."+ Convert.ToString(y);
                 
                }

            }

            int iMax = i;
            int jMax = j;

            
            Console.WriteLine($"Ваш двухмерный массив размерностью {i} на {j}:");

            //вывод его
            for (j = 0; j < jMax; j++)
            {
                for (i = 0; i < iMax; i++)
                {
                    Console.Write($"{array[i, j] }" + " ");
                }

                Console.WriteLine("\b");

            }

            //выводим значения по диагонали

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Элементы массива по диагонали:");
            i = 0;
            j = 0;

            do
            {
                Console.Write($"{array[i, j] } "+" ");
                i++;
                j++;
               

            } while (i < iMax);


            Console.ReadLine();



           

        }
    }
}
