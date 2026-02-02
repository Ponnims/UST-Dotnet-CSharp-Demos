using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvFeatures
{
    internal class SwitchExpressions
    {
        static void Main(string[] args)
        {
            int age = 25;
            string category = age switch
            {
                < 13 => "Child",
                >= 13 and < 20 => "Teenager",
                >= 20 and < 65 => "Adult",
                _ => "Senior"
            };

            Console.WriteLine($"Age: {age}, Category: {category}");
        }
    }
}
