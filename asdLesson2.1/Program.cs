using System;
using System.Collections.Generic;

namespace asdLesson2._1
/*
                     1. Двусвязный список
        Требуется реализовать класс двусвязного списка операции вставки, удаления и поиска элемента в нём в соответствии с интерфейсом.
        namespace GeekBrainsTests
        {
            public class Node
            {
                  public int Value { get; set; }
                  public Node NextNode { get; set; }
                  public Node PrevNode { get; set; }
            }//Начальную и конечную ноду нужно хранить в самой реализации интерфейса
            public interface ILinkedList
            {
                  int GetCount(); // возвращает количество элементов в списке
                  void AddNode(int value);  // добавляет новый элемент списка
                  void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
                  void RemoveNode(int index); // удаляет элемент по порядковому номеру
                  void RemoveNode(Node node); // удаляет указанный элемент
                  Node FindNode(int searchValue); // ищет элемент по его значению
            }
        } */
{
    class Program
    {

        public class Node
        {
            public int Value { get; set; }
            public Node NextNode { get; set; }
            public Node PrevNode { get; set; }
        }

        static void Main(string[] args)
        {
            /*var first = new Node { Value = 1 }; //создание элемента - уже что-то))
            var second = new Node { Value = 2 };

            first.NextNode = second;
            second.PrevNode = first;

            var therd = new Node { Value = 3 };*/

            int[] array = { 1, 2, 3, 4, 5 };


        }

        //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
        public interface ILinkedList //интерфейс это набор методов и свойств без реализации (индекасторы, события, статические поля и константы)
        {
            int GetCount(); // возвращает количество элементов в списке
            void AddNode(int value);  // добавляет новый элемент списка
            void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
            void RemoveNode(int index); // удаляет элемент по порядковому номеру
            void RemoveNode(Node node); // удаляет указанный элемент
            Node FindNode(int searchValue); // ищет элемент по его значению
        }



         public class LinkedClass : ILinkedList
         {
            public Node firstNode { get; set; }
            public Node lastNode { get; set; }

            public void AddNode(int value) // добавляет новый элемент списка
             {
                 while(Node.NextNode!=null)
                 {
                     node = node.NextNode;
                 }

                 var newNode = new Node { Value = value };
                 node.NextNode = newNode;
             }

            public void AddNodeAfter(Node node, int value) // добавляет новый элемент списка после определённого элемента
             {
                 /*var newNode = new Node { Value = value };
                 var nextItem = node.NextItem;
                 node.NextItem = newNode;
                 newNode.NextNode = nextItem;*/

             }

             public Node FindNode(int searchValue) // ищет элемент по его значению
             {
                /* var currentNode=new */
             }

             public int GetCount() // возвращает количество элементов в списке
             {
               /*  int i = 0;
                 while(Node.=null)
                 {
                     i++;
                 }
                 return i;*/

             }

             public void RemoveNode(int index) // удаляет элемент по порядковому номеру
             {

                FirstNode. = null;
                public Node LastNode { get; set; } = null;
             }

             public void RemoveNode(Node node) // ищет элемент по его значению
             {/*
                 var currentNode = node;

                 while(currentNode!=null)
                     {
                     if (currentNode =) 
                     { 
                     }*/

             }
         }

    }
}
