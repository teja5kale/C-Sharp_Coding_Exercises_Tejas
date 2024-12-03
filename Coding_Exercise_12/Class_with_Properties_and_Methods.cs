using System;

namespace Coding_Exercise_12
{
    public class Class_with_Properties_and_Methods
    {
        public class Person
        {
            private string _name;
            private int _age;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public int Age
            {
                get { return _age; }
                set
                {
                    if (value > 0)
                    {
                        _age = value;
                    }
                }
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void Greet()
            {
                Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
            }
        }

        public static void Main(string[] args)
        {
            Person person = new Person("John", 30);

            person.Greet();

            Console.ReadKey();
        }
    }
}
