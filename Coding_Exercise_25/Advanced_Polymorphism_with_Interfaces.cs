using System;

namespace Coding_Exercise_25
{
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle : IShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea()
        {
            return width * height;
        }
    }

    internal class ADVANCED_Polymorphism_with_Interfaces
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(5); 
            IShape rectangle = new Rectangle(4, 6);

            Console.WriteLine("Circle Area: " + circle.GetArea());

            Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
        }
    }
}
