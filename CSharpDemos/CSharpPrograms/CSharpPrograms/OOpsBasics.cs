using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{

    class CustomerOld
    {
        //fields
        private int customerId;
        private string customerName;
        private string customerAddress;
        //properties
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public string CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }
        }
        //methods
        public void DisplayCustomerInfo()
        {
            Console.WriteLine("Customer ID: " + customerId);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Customer Address: " + customerAddress);
        }
    }

    class Customer
    {
        // Auto-Implemented Properties
        public int CustomerId { get; } = 10;
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        // Method
        public void DisplayCustomerInfo()
        {
            Console.WriteLine("Customer ID: " + CustomerId);
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Customer Address: " + CustomerAddress);
        }
    }
    internal class OOpsBasics
    {
        static void Main(string[] args)
        {
            // Creating an instance of CustomerOld
            CustomerOld oldCustomer = new CustomerOld();
            oldCustomer.CustomerId = 1;
            oldCustomer.CustomerName = "John Doe";
            oldCustomer.CustomerAddress = "123 Main St";
            oldCustomer.DisplayCustomerInfo();

            // Creating an instance of Customer
            Customer newCustomer = new Customer();
            newCustomer.CustomerId = 2;
            newCustomer.CustomerName = "Jane Smith";
            newCustomer.CustomerAddress = "456 Elm St";
            newCustomer.DisplayCustomerInfo();
        }
    }
}

        }
    }
}
