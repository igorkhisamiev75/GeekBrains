using System;
using System.Diagnostics;


namespace lesson6
{
    class Program6
    {
        /*Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
         * Предусмотреть возможность завершения процессов 
         * с помощью указания его ID или имени процесса. В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.*/

        static void Main(string[] args)
        {
           
            Process[] proc = Process.GetProcesses();
            int pCount = proc.Length;

            for (int i = 0; i < pCount; i++)
            {
                Console.WriteLine($"{i}\t" + proc[i].ProcessName + "/" + proc[i].PrivateMemorySize64);
            }

            Console.WriteLine("Укажите номер или имя процесса, который хотите завершить:");
            string NameProcess = Console.ReadLine();

            //цикл для поиска совпадений по имени, если не находит то по номеру

            for (int i = 0; i < pCount; i++)
            {
                if (proc[i].ProcessName == NameProcess)
                {
                    proc[i].Kill();
                }

            }

            //закрытие по номеру, если в имени не нашлось совпадений
            try
            {
                int numName = Convert.ToInt32(NameProcess);
                proc[numName].Kill();

            }

            catch
            {
                Console.WriteLine("Закрыли по имени");
            }
            
            Console.ReadKey();
        }

       
    }
}
