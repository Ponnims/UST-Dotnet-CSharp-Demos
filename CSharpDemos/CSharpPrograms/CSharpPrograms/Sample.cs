using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class Sample
    {
        public static void Main(string[] args)
        {
            int? id = null;
            Nullable<int> bonus = null;
            string name;
            bool isActive;
            float salary;

            Console.WriteLine("Enter Your Id");
            id =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Your Name");
            name = Console.ReadLine();
            Console.WriteLine("Are you Active?");
            isActive = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Your Salary");
            salary = Convert.ToSingle(Console.ReadLine());
        }
    }
}
