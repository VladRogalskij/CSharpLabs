using System;

namespace Pr1
{
    class Task1:ITask
    {
        public void TaskX()
        {
            chooseNumsInInterval(num1: 5, num2: 18, num3: 35, N: 21);
        }
        static public void chooseNumsInInterval(int num1, int num2, int num3, int N)
        {
            int[] numArr = { num1, num2, num3 };
            for (int i = 0; i < numArr.Length; i++ )
            {
                if (1 < numArr[i] && numArr[i] < 10 + N)
                {
                    Console.WriteLine(numArr[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
