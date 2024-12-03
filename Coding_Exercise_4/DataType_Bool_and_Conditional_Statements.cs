using System;

namespace Coding_Exercise_4
{
    internal class DataType_Bool_and_Conditional_Statements
    {
        public void CheckLogin()
        {
            bool isLoggedIn = false;

            if (isLoggedIn)
            {
                Console.WriteLine("Welcome back!");
            }
            else
            {
                Console.WriteLine("Please log in.");
            }
        }

        static void Main(string[] args)
        {
            DataType_Bool_and_Conditional_Statements exercise = new DataType_Bool_and_Conditional_Statements();

            exercise.CheckLogin();

            Console.ReadKey();
        }
    }
 
}
