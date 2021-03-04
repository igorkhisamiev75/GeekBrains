using System;

namespace asdLesson3
{
    /*Напишите тесты производительности для расчёта дистанции между точками с помощью BenchmarkDotNet. 
     * Рекомендуем сгенерировать заранее массив данных, чтобы расчёт шёл с различными значениями, 
     * но сам код генерации должен происходить вне участка кода, время которого будет тестироваться.
        Для каких методов потребуется написать тест:
        1 Обычный метод расчёта дистанции со ссылочным типом (PointClass — координаты типа float).
        2 Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа float).
        3 Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа double).
        4 Метод расчёта дистанции без квадратного корня со значимым типом (PointStruct — координаты типа float).
        
        Результаты можно оформить в виде списка или таблицы, в которой наглядно можно будет увидеть время выполнения того или иного метода.
     */
    class Program
    {
        public class PointClassFloat
        {
            public float X;
            public float Y;

        }

        public struct PointStructFloat
        {
            public float X;
            public float Y;

        }

        static void Main(string[] args)
        {
            var point1 = new PointClassFloat() { X = 42, Y = 42 };
            var point2 = new PointClassFloat() { X = 0, Y = 0 };

            Console.WriteLine(PointDistanceClass(point1, point2));

            PointStructFloat pointStruct1;
            pointStruct1.X = 42;
            pointStruct1.Y = 42;

            PointStructFloat pointStruct2;
            pointStruct2.X = 0;
            pointStruct2.Y = 0;

            Console.WriteLine(PointDistanceStruct(pointStruct2, pointStruct1));


        }
        public static float PointDistanceClass(PointClassFloat pointOne, PointClassFloat pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceStruct(PointStructFloat pointOne, PointStructFloat pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static void PrintPoint(PointClassFloat pointClass, string tag)
        {
            Console.WriteLine($"{tag}\t X:{pointClass.X}, Y:{pointClass.Y}");
        }
    }
}
