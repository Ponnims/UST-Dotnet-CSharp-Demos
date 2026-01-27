using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{

    interface IPayement
    {
               void MakePayment(decimal amount);

    }

    class CreditCardPayment : IPayement
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}");
        }
    }

    class PayPalPayment : IPayement
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    }

    class UPIPayment : IPayement
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing UPI payment of {amount:C}");
        }
    }

    class GpayPayment : IPayement
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing Gpay payment of {amount:C}");
        }
    }

    internal class AbstractionDemo
    {
        static void Main(string[] args)
        {
            IPayement paymentMethod;
            // Using Credit Card Payment
            paymentMethod = new CreditCardPayment();
            paymentMethod.MakePayment(150.75m);
            // Using PayPal Payment
            paymentMethod = new PayPalPayment();
            paymentMethod.MakePayment(200.00m);
            // Using UPI Payment
            paymentMethod = new UPIPayment();
            paymentMethod.MakePayment(300.50m);
            // Using Gpay Payment
            paymentMethod = new GpayPayment();
            paymentMethod.MakePayment(400.25m);
            // Using PhonePe Payment
           

        }
    }
}
