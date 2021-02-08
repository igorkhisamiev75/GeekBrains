using System;
using System.IO;

namespace lesson5._4
{
    class Program

    {
        /*(*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.*/

        static void Main(string[] args)
        {
            //C рекурсией
            string path = @"C:\Первая";
            //string fileName = "strartup.txt";


            static string[] Dir(string path2) //метод Dir принимает путь, возвращает папки и колличество папок
            {
                
                string[] allfiles2 = Directory.GetDirectories(path2); /* получаем массив всех папок в папке пути*/
                int i = allfiles2.Length; //получение длины массива

                for (int j = 0; j <= i - 1; j++)
                {
                    Console.Write($"{path2}\n"); //выводим путь
                    
                    Dir(allfiles2[j]);
                    Console.Write($"\t{allfiles2[j]}\n");

                }
                
                return allfiles2;
            }

            Dir(path);

         }

       
    }
}
