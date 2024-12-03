using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int Not_Hungry_Cats(string kitchen)
        {
            kitchen = kitchen.Replace(" ", "");
            string[] cats = kitchen.Split('F');

            string left = cats[0];
            string right = cats[1];
            int ans = 0;

            for (int i = 0; i < left.Length; i = i + 2)
            {
                if (left[i] == 'O')
                {
                    ans++;
                }
            }

            for (int i = 0; i < right.Length; i = i + 2)
            {
                if (right[i] == '~')
                {
                    ans++;
                }
            }

            return ans;
        }

        static void Main(string[] args)
        {
            string kitchen = "O O F ~ ~ F";
            int result = Not_Hungry_Cats(kitchen);
            Console.WriteLine($"Number of hungry cats: {result}");
        }
    }
}
