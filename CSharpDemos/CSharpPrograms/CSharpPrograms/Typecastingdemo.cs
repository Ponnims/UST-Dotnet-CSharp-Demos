using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class Typecastingdemo
    {
        static void Main(string[] args)
        {
            int a = 10;
            float b = a; // implicit typecasting
            Console.WriteLine($"Implicit Typecasting: {b}");

            float x = 10.5f;
            int y = (int)x; // explicit typecasting
            Console.WriteLine($"Explicit Typecasting: {y}");


            int num = 65;
            object obj = num; // boxing
            Console.WriteLine(obj);

            int unboxedNum = (int)obj; // unboxing
            Console.WriteLine($"Unboxed Number: {unboxedNum}");
        }
    }
}
