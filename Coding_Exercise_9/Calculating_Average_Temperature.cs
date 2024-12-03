using System;

namespace Coding_Exercise_9
{
    internal class Calculating_Average_Temperature
    {
        static void Main(string[] args)
        {
            double[] temperatures = { 30.5, 32.0, 31.8, 29.4, 28.9 };

            double total = 0;
            foreach (double temp in temperatures)
            {
                total += temp;
            }
            double average = total / temperatures.Length;

            Console.WriteLine("The average temperature is: " + average);

            Console.ReadKey();
        }
    }
}
