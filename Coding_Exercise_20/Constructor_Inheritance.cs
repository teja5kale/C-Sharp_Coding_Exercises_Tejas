using System;

namespace Coding_Exercise_20
{
    public class Person
    {
        public Person(string name)
        {
            Console.WriteLine($"Person constructor: {name}");
        }
    }

    public class Employee : Person
    {
        public Employee(string name, int id) : base(name)
        {
            Console.WriteLine($"Employee constructor: {name}, ID: {id}");
        }
    }

    internal class Constructor_Inheritance
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John Doe", 123);
        }
    }
}
