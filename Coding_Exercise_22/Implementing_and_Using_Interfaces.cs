using System;

namespace Coding_Exercise_22
{
    public interface IVehicle
    {
        void Drive();
    }

    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }

    internal class Implementing_and_Using_Interfaces
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new Car();
            vehicle.Drive(); 
        }
    }
}
