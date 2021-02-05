using System;

namespace lesson2._6
{
    class Program
    {
        [Flags]
        public enum DaysWork
        {
            
            Monday=     0b_0000001,
            Tuesday =   0b_0000010,
            Wednesday = 0b_0000100,
            Thursday =  0b_0001000,
            Friday =    0b_0010000,
            Saturday =  0b_0100000,
            Sunday =    0b_1000000,
        }
        static void Main(string[] args)
        {
            DaysWork office1 =  DaysWork.Tuesday | DaysWork.Wednesday | DaysWork.Thursday | DaysWork.Friday; 
            DaysWork office2 = DaysWork.Monday | DaysWork.Tuesday | DaysWork.Wednesday | DaysWork.Thursday | DaysWork.Friday | DaysWork.Saturday | DaysWork.Sunday;

            Console.WriteLine($"Офис 1 работает: {office1}");
            Console.WriteLine($"Офис 2 работает: {office2}");

            Console.ReadLine();
        }
    }
}
