using System;

namespace lesson4._1
{
    class Program
    {
        static void Main()
        {
            (string firstName, string lastName, string patronymic)[] users = CreateUsers();
            ShowMenu(users);

        }

        static (string firstName, string lastName, string patronymic)[] CreateUsers()
        {
            Console.WriteLine("Введите количество пользователей:");
            int count = ReadInt();

            (string firstName, string lastName, string patronymic)[] users = new (string firstName, string lastName, string patronymic)[count];

            for (int i = 0; i < users.Length; i++)
            {
                users[i] = CreateUser();
                Console.WriteLine($"Пользователь {GetFullName(users[i])} сохранен");
            }

            Console.WriteLine("Ввод данных завершён. Нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();

            return users;
        }

        static (string userFirstName, string userLastName, string userPatronymic) CreateUser()
        {
            Console.Write("Введите Фамилию пользователя: ");
            string userName = Console.ReadLine();

            Console.Write("Введите Имя пользователя: ");
            string userLastName = Console.ReadLine();

            Console.Write("Введите Отчество пользователя: ");
            string userPatronymic = Console.ReadLine();
           
            return (userName, userLastName, userPatronymic);
        }

        static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static string GetFullName((string a, string b, string c) user)
        {
            return (user.a +" "+ user.b+" "+user.c);
        }


        static void ShowMenu((string firstName, string lastName, string patronymic)[] users)
        {
            int choice;
            do
            {
                choice = GetUserChoice();
                switch (choice)
                {
                    case 0: return;
                    case 1:
                        PrintUsers(users);
                        break;
                    case 2:
                        PrintSelectedUser(users);
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
        }

        static int GetUserChoice()
        {
            Console.WriteLine("0 - Завершение работы");
            Console.WriteLine("1 - Просмотр всей базы данных");
            Console.WriteLine("2 - Просмотр пользователя");
            return ReadInt();
        }

        static void PrintSelectedUser((string firstName, string lastName, string patronymic)[] users)
        {
            int userIndex;
            do
            {
                Console.WriteLine($"Введите идентификатор пользователя - от 0 до {users.Length - 1}");
                userIndex = ReadInt();
            } while (userIndex < 0 || userIndex >= users.Length);

            PrintUser(users[userIndex]);
        }

        static void PrintUsers((string firstName, string lastName, string patronymic)[] users)
        {
            Console.WriteLine("Вывод базы данных:");
            for (int i = 0; i < users.Length; i++)
            {
                PrintUser(users[i]);
            }
        }

        static void PrintUser((string firstName, string lastName, string patronymic) user)
        {
            Console.WriteLine(GetFullName(user));
        }


    }
}

