using System;

namespace Coding_Exercise_11
{
    internal class Using_Static_Methods
    {
        public static int DoubleValue(int number)
        {
            return number * 2;
        }

        static void Main(string[] args)
        {
            int result = DoubleValue(10);
    
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
