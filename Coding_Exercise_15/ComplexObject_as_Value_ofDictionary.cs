using System;
using System.Collections.Generic;

namespace Coding_Exercise_15
{
    internal class ComplexObject_as_Value_ofDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> myDictionary = new Dictionary<string, List<int>>();

            myDictionary.Add("a", new List<int> { 1, 2, 3 });

            foreach (var number in myDictionary["a"])
            {
                Console.Write(number + " ");
            }
            Console.ReadKey();
        }
    }
}
