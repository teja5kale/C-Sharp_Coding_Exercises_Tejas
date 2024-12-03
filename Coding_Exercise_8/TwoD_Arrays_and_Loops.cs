using System;

namespace Coding_Exercise_8
{
    internal class TwoD_Arrays_and_Loops
    {
        static void Main(string[] args)
        {
            int[,] arr =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += arr[i, j];
                }
                Console.WriteLine(sum);
            }

            Console.ReadKey();
        }
    }
}
