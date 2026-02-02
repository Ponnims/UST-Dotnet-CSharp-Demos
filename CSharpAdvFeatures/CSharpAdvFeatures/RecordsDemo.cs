using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvFeatures
{
    // records are reference types with value-based equality
    // concise syntax for defining immutable data objects
    // it is like lightweight class primarily used to store data
    public record Person(string FirstName, string LastName);
    internal class RecordsDemo
    {

        public static Person Display()
        {
            return new Person("Jane", "Doe");
        }
        static void Main(string[] args)
        {
            var p1 = new Person("John", "Doe");
            var p2 = new Person("John", "Doe");
            Console.WriteLine($"Are both persons equal? {p1 == p2}");


            var personFromMethod = Display();
            Console.WriteLine($"Person from method: {personFromMethod.FirstName} {personFromMethod.LastName}");


            //with-expressions for non-destructive mutation
            // creates a new record instance based on an existing one with some properties modified


            var person3 = new Person("Alice", "Smith");
            var Person4 = person3 with { LastName = "Johnson" };

            Console.WriteLine($"Person4: {Person4.FirstName} {Person4.LastName}");
            Console.WriteLine($"Person3: {person3.FirstName} {person3.LastName}");


            // person3.FirstName = "Bob"; // This line will cause a compile-time error because records are immutable by default
            //            Person4.FirstName = "jhhj";

        }
    }
}
