using System;
using System.Collections.Generic;


namespace Pr1
{
    class Task4:ITask
    {
        public void TaskX()
        {
            RandInputArray();
            M = 40;
            Console.WriteLine($"M is {M} ");
            OutputArray(X);
            OutputArray(newArrY(40));
        }

        private static int N = 7; // last digit of student group
        private static int SIZE_OF_ARRAY_X = 10 + N;
        public static int[] X = new int[SIZE_OF_ARRAY_X];
        public static int M { get; set; }
        public static void RandInputArray()
        {
            Random random = new Random();
            for(int i = 0; i < SIZE_OF_ARRAY_X; i++)
            {
                X[i] = random.Next(-100, 100);
            }
        }

        public static void OutputArray(int[] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        public static int[] newArrY (int M)
        {

            List<int> Y = new List<int>();

            foreach (var x in X)
            {
                if (Math.Abs(x) > M)
                {
                    Y.Add(x);
                }
            }

            return Y.ToArray();
        }
    }
}
