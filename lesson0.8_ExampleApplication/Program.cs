using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lesson0._8_ExapleLibrary;

namespace lesson0._8_ExampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите своё имя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.age))
            {
                Console.WriteLine("Введите ваш возраст:");
                Properties.Settings.Default.age= Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.workTitle))
            {
                Console.WriteLine("Введите кто вы:");
                Properties.Settings.Default.workTitle = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            string userName = Properties.Settings.Default.UserName;
            string age = Properties.Settings.Default.age;
            string workTitle = Properties.Settings.Default.workTitle;
            string greeting = Properties.Settings.Default.Greeting;

            Console.WriteLine($"{greeting}, {userName}, тебе {age} вы {workTitle}");

            //Greeting.SayHello();
            Console.ReadLine();

        }
    }
}
