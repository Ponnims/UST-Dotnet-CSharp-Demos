using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
   interface INotification
    {
        void Send(string message);
    }

    class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Email Notification: " + message);
        }
    }

    class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS Notification: " + message);
        }
    }

    internal class Polymorphismdemo
    {
        static void Main(string[] args)
        {
            INotification notification;

            notification = new EmailNotification();
            notification.Send("Hello via Email!");

            // You can add more notification types here
        }
    }
}
