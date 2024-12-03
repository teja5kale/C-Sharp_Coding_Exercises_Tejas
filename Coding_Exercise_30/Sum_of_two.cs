using System;
using System.Collections.Generic;

namespace Coding_Exercise_30
{
    internal class Sum_of_two
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 3, 4, 5, 2 };
            int sumToFind = 2;

            int result = SumOfTwo(nums, sumToFind);
            Console.WriteLine($"Number of unique pairs with sum {sumToFind}: {result}");
        }

        public static int SumOfTwo(int[] nums, int sumToFind)
        {
            HashSet<int> seen = new HashSet<int>();
            HashSet<Tuple<int, int>> uniquePairs = new HashSet<Tuple<int, int>>();

            foreach (int num in nums)
            {
                int complement = sumToFind - num;

                if (seen.Contains(complement))
                {
                    int smaller = Math.Min(num, complement);
                    int larger = Math.Max(num, complement);
                    uniquePairs.Add(new Tuple<int, int>(smaller, larger));
                }

                seen.Add(num);
            }

            return uniquePairs.Count;
        }
    }
}
