using System;

namespace Coding_Exercise_19
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Dog barks");
        }
    }

    internal class Inheritance_and_Base_Keyword
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound(); 
        }
    }
}
