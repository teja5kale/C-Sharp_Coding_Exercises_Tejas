using System;
using System.Text.RegularExpressions;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void ExtractPatterns(string input)
        {
            string emailPattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

            MatchCollection matches = Regex.Matches(input, emailPattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Extracting Email Addresses with Regex");

            string input = "Contact us at support@example.com or sales@example.org. For inquiries, reach out to team@company.net.";

            Exercise exercise = new Exercise();
            exercise.ExtractPatterns(input);
        }
    }
}
