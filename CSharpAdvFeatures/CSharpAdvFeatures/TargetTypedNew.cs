using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvFeatures
{
    class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
    internal class TargetTypedNew
    {
        static void Main(string[] args)
        {
            List<int> scores = new() { 90, 85, 78, 92, 88 };

            Employee emp = new() { Name = "Alice", Id = 101 };
           // Employee emp1= new Employee() { Name = "Bob", Id = 102 };
        }
    }
}
