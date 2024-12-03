using System;

namespace Coding_Exercise_23
{
    public interface IPayment
    {
        void ProcessPayment();
    }

    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment");
        }
    }

    public class PayPalPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment");
        }
    }

    internal class Polymorphism_with_Interfaces
    {
        static void Main(string[] args)
        {
            IPayment creditCardPayment = new CreditCardPayment();
            IPayment payPalPayment = new PayPalPayment();

            creditCardPayment.ProcessPayment();
            payPalPayment.ProcessPayment();
        }
    }
}
