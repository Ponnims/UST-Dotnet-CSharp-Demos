using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvFeatures
{
    class Sample
    {
        public (string firstname, int age) Getperson()
        {
            return ("John", 12);
        }
    }
    internal class TuplewithNamedElementsdemo
    {
        static void Main(string[] args)
        {
            var sample = new Sample();
            var person = sample.Getperson();
            Console.WriteLine($"Name: {person.firstname}, Age: {person.age}");
        }
    }
}
