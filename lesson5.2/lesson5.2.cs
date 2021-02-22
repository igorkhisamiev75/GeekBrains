using System;
using System.IO;

namespace lesson5._2
{
    class Program
    {
        /*Написать программу, которая при старте дописывает текущее время в файл «startup.txt».*/

        static void Main(string[] args)
        {
            string fileName = "strartup.txt";

            string text = Convert.ToString(DateTime.Now);

            File.WriteAllText(fileName, text);

        }
    }
}
