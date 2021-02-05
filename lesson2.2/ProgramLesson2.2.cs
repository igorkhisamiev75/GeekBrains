using System;

namespace lesson2._2
{
    class Program
    {    
           static void Main(string[] args)
        {
            string[] month = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int i;

            Console.WriteLine("Введите порядковый номер месяца от 1 до 12");

            do
            {
              
               i = Convert.ToInt32(Console.ReadLine());

                if (i <= 12)
                {
                    Console.WriteLine(month[i - 1]);
                }

                else
                {
                    Console.WriteLine("Ошибка, нужно ввести число от 1 до 12, повторите попытку \n");
                }


            } while (i > 12);

            Console.ReadKey();
        }
    }
}
