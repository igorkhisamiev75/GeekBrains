using System;
using System.IO;

namespace lesson5._1
{
    class Program
    {
        /*Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.*/

        static void Main(string[] args)
        {
            string fileName = "Note.txt";

            Console.WriteLine("Введите текст, который будет записан  в тектовый файл");
            string text = Console.ReadLine();

            File.WriteAllText(fileName, text);

        }
    }
}
