using System;

namespace Pr1
{
    class Task3:ITask
    {
        public void TaskX()
        {
            RandInputArray();
            OutputArray();
            Console.WriteLine($"Min value is {MinValue()}");
            Console.WriteLine($"Max value is {MaxValue()}");
        }

        private static int N = 7; // last digit of student group
        private static int SIZE_OF_ARRAY = 10 + N;
        private static byte[] X = new byte[SIZE_OF_ARRAY];
        public static void RandInputArray()
        {
            Random random = new Random();            
            random.NextBytes(X);             
        }

        public static void OutputArray()
        {
            Console.WriteLine();
            foreach (var x in X)
            {
                Console.Write($"{x} ");
            }
        }

        public static byte MinValue()
        {
            byte minValue = byte.MaxValue;

            foreach (var x in X)
            {
                if (x < minValue)
                {
                    minValue = x;
                }
            }
            return minValue;
        }
        public static byte MaxValue()
        {
            byte maxValue = byte.MinValue;

            foreach (var x in X)
            {
                if (x > maxValue)
                {
                    maxValue = x;
                }
            }
            return maxValue;
        }
    }
}
