using System;

namespace lesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameShop = "ВкусВилл";

            string position1 = "Сахар";
            string position2 = "Молоко";

            double wight1 = 1.1;
            double price1 = 500.6;

            double wight2 = 2;
            double price2 = 98;

            double sumPrice = price1 + price2;

            DateTime date = DateTime.Now;

           

            //Console.SetWindowSize(Console.WindowHeight, 60);
            //Console.SetWindowSize(Console.WindowWidth, 50);

            Console.WriteLine("    \n" +
                $"     {nameShop}     \n \n" +

                    $" {position1}........."+$" {wight1}кг....." + $" { price1} руб.\n" +

                    $" {position2}........." + $" {wight2}л........" + $" { price2} руб.\n\n\n\n" +
                    $" Итоговая сумма:  ..........  {sumPrice}\n\n\n\n");
        }
    }
}
