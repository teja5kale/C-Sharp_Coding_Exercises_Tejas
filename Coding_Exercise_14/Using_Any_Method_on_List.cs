using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding_Exercise_14
{
    internal class Using_Any_Method_on_List
    {
        static void Main(string[] args)
        {
            List<int> myNumbers = new List<int> { 1, 4, 3 };

            bool result = myNumbers.Any(num => num > 5);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
