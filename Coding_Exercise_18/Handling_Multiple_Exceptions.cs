using System;

namespace Coding_Exercise_18
{
    internal class Handling_Multiple_Exceptions
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();

            exercise.HandleMultipleExceptions("2", 1);  
            exercise.HandleMultipleExceptions("invalid", 1); 
            exercise.HandleMultipleExceptions("2", 5); 
        }
    }

    public class Exercise
    {
        public void HandleMultipleExceptions(string str, int index)
        {
            int[] numbers = { 1, 2, 3 };

            try
            {
                int number = int.Parse(str);

                Console.WriteLine(numbers[index]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }
    }
}
