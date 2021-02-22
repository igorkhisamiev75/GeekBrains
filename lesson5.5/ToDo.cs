using System;
using System.Collections.Generic;
using System.Text;

namespace lesson5._5
{
    public class ToDo
    {
        //определяем поля - свойства
        public bool IsDone { get; set; }
        public string Title { get; set; }
        public int Num { get; set; }

        //определяем конструктор

        public ToDo(int num, string title, bool isDone)
        {
            IsDone = isDone;
            Title = title;
            Num = num;


        }
        public ToDo()
        {
            Num = 1;
            Title = "Задача";
            IsDone = true;
        }

        

          

        //метод изменения состояния задачи
        public bool ToDoDone(bool isDone)
        {
            Console.WriteLine("Задача обновлена");
            return IsDone=!isDone;
           
            //дописать обновление экрана с задачей
            
        }

    }
}
