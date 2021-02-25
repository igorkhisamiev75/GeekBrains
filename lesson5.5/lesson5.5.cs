using System;
using System.IO;
using System.Text.Json;

namespace lesson5._5
{
    class Program
    {
        /*(*) Список задач (ToDo-list):
            -написать приложение для ввода списка задач;
            -задачу описать классом ToDo с полями Title и IsDone;
            на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
            если задача выполнена, вывести перед её названием строку «[x]»;
            вывести порядковый номер для каждой задачи;
            при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
            записать актуальный массив задач в файл tasks.json/xml/bin.*/
        static void Main(string[] args)
        {
            
            string tasks = "tasks.json";  // берём данные из файла
            string[] json = File.ReadAllLines(tasks); //считываем в массив строк
            int k = json.Length + 1; //5

            ToDo[] toDos = new ToDo[k]; //создание массива типа todo, с +1 чтобы можно было добавить новую задачу

            toDos[4].IsDone = false;
            toDos[4].Title = "";
            toDos[4].Num = 4;


            ShowToDo(json, toDos);

            //CloseToDoItem(toDos);

            AddItemToDo(toDos, k);

            //ShowToDo(json, toDos);


            //выводим список задач заново
            Console.WriteLine("Обновленный список:\n");

            for (int i = 0; i < json.Length; i++)
            {

                Console.WriteLine($"{toDos[i].Num} .... {toDos[i].Title}.....{ReplaceBool((toDos[i].IsDone))}"); //вывод имени

            }

            Console.ReadKey();

        }

        static ToDo[] AddItemToDo(ToDo[] toDos, int k)
        {
            
            toDos[k - 1].Num = k;
            //запрос имени новой задачи
            //Console.WriteLine("Введите название задачи:");
            string itemNew = "NEW ITEM";//Console.ReadLine();
            
            toDos[k - 1].Title = itemNew;
            
            return (toDos);
            
        }

         static void ShowToDo(string[] json, ToDo[] toDos)
        {
            Console.WriteLine("Ваш список задач:\n");

            //вывод списка задач
            for (int i = 0; i < json.Length; i++)
            {
                    toDos[i] = JsonSerializer.Deserialize<ToDo>(json[i]); //десериализуем в массив
                    Console.WriteLine($"{toDos[i].Num} .... {toDos[i].Title}.....{ReplaceBool((toDos[i].IsDone))}"); //вывод имени 
              
                }


        }

        static ToDo[] CloseToDoItem(ToDo[] toDos)
        {
            //запрос номера задачи которую выполнили
            int n = NumberTaskComplite();
            toDos[n].IsDone = true;
            return (toDos);
            //ShowToDo(json, toDos);
            //Console.WriteLine($"{toDos[n].Num} .... {toDos[n].Title}.....{ReplaceBool((toDos[n].IsDone))}"); //вывод имени
        }



      

        static int NumberTaskComplite()
        {
            Console.WriteLine("Введите номер задачи которую выполнили:");
            return  (Convert.ToInt32(Console.ReadLine())-1);
        }

        static int GetUserChoice()
        {
            Console.WriteLine("0 - Завершение работы");
            Console.WriteLine("1 - Добавить задачу");
            Console.WriteLine("2 - Закрыть задачу");
            Console.WriteLine("3 - Показать все данные");
            return ReadInt();
        }

    /*
        static void ShowMenu()
        {
            int choice;
            do
            {
                choice = GetUserChoice();
                switch (choice)
                {
                    case 0: return;
                    case 1:
                        AddItemToDo();
                        break;
                    case 2:
                        CloseToDoItem();
                        break;
                    case 3:
                        ShowToDo();
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
        }*/

        static string ReplaceBool(bool trueFalse)
        {

            if (trueFalse == true)
            {
                return "[x]";
            }
            else
            {
                return "[0]";
            }

        }

        static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }


    }
}
