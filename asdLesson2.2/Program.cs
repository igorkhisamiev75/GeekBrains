using System;

namespace asdLesson2._2
{
    class Program
    {
        /*2. Двоичный поиск
        Требуется написать функцию бинарного поиска, 
        посчитать его асимптотическую сложность и проверить работоспособность функции.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("введите число для поиска в массиве 116 59 158");
            int[] inputArray = { 6, 59, 158 };
            int searchVale = Convert.ToInt32(Console.ReadLine());

            int a=BinarySearch(inputArray, searchVale)+1;
            Console.WriteLine(a);

        }

        public static int BinarySearch(int[] inputArray, int searchValue) //асимптотическая сложность О(log(N))
        {
            int min = 0; 
            int max = inputArray.Length - 1; 
            while (min <= max) 
            {
                int mid = (min + max) / 2; 
                if (searchValue == inputArray[mid]) 
                {
                    return mid; 
                }

                else if (searchValue < inputArray[mid])  
                {
                    max = mid - 1; 
                }

                else
                {
                    min = mid + 1; 
                }
            }
            return -1;  

        }
    }
}
