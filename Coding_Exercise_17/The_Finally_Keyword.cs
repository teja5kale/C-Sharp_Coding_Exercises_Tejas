using System;

namespace Coding_Exercise_17
{
    internal class The_Finally_Keyword
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Trying...");
            }
            finally
            {
                Console.WriteLine("Finally executed.");
            }
            Console.ReadKey();
        }
    }
}
