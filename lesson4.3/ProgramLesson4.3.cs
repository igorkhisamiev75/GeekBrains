using System;

namespace lesson4._3
{
    class Program
    {
        [Flags]
        public enum TimeYearText
        {
            Winter=1,
            Spring,
            Summer, 
            Autumn,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца от 1 до 12");
            int i;

            do
            {
                i = Convert.ToInt32(Console.ReadLine());

                if (i <= 12 && i>0)
                {
                    Console.WriteLine($"Сейчас {TimeYear(i)}"); 
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("Ошибка, нужно ввести число от 1 до 12, повторите попытку \n");
                }


            } while (i > 12 || i<=0);

        }

        static string TimeYear(int i)
        {
            if (i==12||i==1||i==2)
            {
                return Convert.ToString(TimeYearText.Winter);
            }

            else if (i == 3 || i == 4 || i == 5)
            {
                return Convert.ToString(TimeYearText.Spring);
            }

            else if (i == 6 || i == 7 || i == 8)
            {
                return Convert.ToString(TimeYearText.Summer);
            }
            {
                return Convert.ToString(TimeYearText.Autumn);
            }
        }
    }
}
