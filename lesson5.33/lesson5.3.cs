using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace lesson5._33
{

    class Program
    {
        /*Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.*/

        static void Main(string[] args)
        {
            string filePath = "bimFile.bin";

            Console.WriteLine("Введите произвольный набор от 0..255");
            string str = Console.ReadLine();

            string[] num = str.Split(' ');
      
            byte[] bytNum = new byte[num.Length];

            for (int i=0; i<=(num.Length-1); i++)
            {
                bytNum[i] = Convert.ToByte(num[i]);
                Console.WriteLine(bytNum[i]);
            }

            File.WriteAllBytes(filePath, bytNum);

        }
    }
}
