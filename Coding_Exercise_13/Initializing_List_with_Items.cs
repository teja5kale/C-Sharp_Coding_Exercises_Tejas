using System;
using System.Collections.Generic;

namespace Coding_Exercise_13
{
    internal class Initializing_List_with_Items
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3 };

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}
