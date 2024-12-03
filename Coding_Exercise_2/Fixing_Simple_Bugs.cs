using System;

namespace Coding_Exercise_2
{
    internal class Fixing_Simple_Bugs
    {
        public Fixing_Simple_Bugs()
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            int average = (num1 + num2 + num3) / 3;

            Console.WriteLine("The average is: " + average);

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Fixing_Simple_Bugs exercise = new Fixing_Simple_Bugs();
        }
    }
}
