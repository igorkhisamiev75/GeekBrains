using System;
using System.Collections.Generic;

namespace asdLesson2._1
/*
                     1. Двусвязный список
        Требуется реализовать класс двусвязного списка операции вставки, 
удаления и поиска элемента в нём в соответствии с интерфейсом.
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
           LinkedClass linkedList = new LinkedClass();


            linkedList.AddNode(1);
            linkedList.AddNode(2);
            linkedList.AddNode(3);
            linkedList.AddNode(4);
            linkedList.AddNode(5);

            Console.WriteLine(linkedList.GetCount());

            Console.WriteLine(linkedList.FindNode(3).Value);

            linkedList.RemoveNode(3);
           
            linkedList.AddNodeAfter(linkedList.firstNode, 5);

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

            public Node currentNode { get; set; }

            public void AddNode(int value) // добавляет новый элемент списка
             {
                var node = new Node { Value = value };

                if (firstNode == null)
                {
                    firstNode = node;
                }
                else
                {
                    lastNode.NextNode = node;
                    node.PrevNode = lastNode;
                }
                lastNode = node;
            }
           
            public void AddNodeAfter(Node node, int value) // добавляет новый элемент списка после определённого элемента
             {
                //int j=FindNode();
                var newNode = new Node { Value = value }; // новая нода
                Node currentNode = node; //текущая нода после которой вставляем новый элемент value
                
                newNode.PrevNode = currentNode; //в новой ноде назначаем предыдущую текущую

                if (currentNode.NextNode==null)
                {
                    newNode.NextNode = null;
                }
                else
                {
                    var nextNode = currentNode.NextNode; //следующая нода для текущей
                                    newNode.NextNode = nextNode; //для новой назначаем
                    nextNode.PrevNode = newNode; //для следующей записываем новую 
                }
                
             }

             public Node FindNode(int searchValue) // ищет элемент по его значению
             {
                while (firstNode.Value!=searchValue)
                {
                    firstNode = firstNode.NextNode;
                    
                }
                return firstNode;
             }

             public int GetCount() // возвращает количество элементов в списке
             {
                int i = 1;
                if (firstNode.NextNode == null)
                {
                    return i;
                }
                else do
                    {
                        i++;
                        firstNode = firstNode.NextNode;
                    } while (firstNode.NextNode != null);

                return i;
            }

            public void RemoveNode(int index) // удаляет элемент по порядковому номеру
             {
                var removeNode = new Node { Value = index };

                var findNode = firstNode;

                while (removeNode.Value != findNode.Value)
                {
                    findNode = findNode.NextNode;

                }
                var next = findNode.NextNode;
                var prev = findNode.PrevNode;
                prev.NextNode = next;
                next.PrevNode = prev;

            }

             public void RemoveNode(Node node) // ищет элемент по его значению
             {
                var removeNode = node;
                var findNode = firstNode;

                while (findNode != removeNode)
                {
                    findNode = findNode.NextNode;
                }
                var next = findNode.NextNode;
                var prev = findNode.PrevNode;
                prev.NextNode = next;
                next.PrevNode = prev;

            } 
         }

    }
}
