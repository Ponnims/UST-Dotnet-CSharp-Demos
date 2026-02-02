using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvFeatures
{
    class Partcipant
    {
        public string Name { get; }
        public int Age { get; }
        public Partcipant(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Deconstruct(out string name, out int age)
        {
            name = Name;
            age = Age;
        }
    }
    internal class DeConstructionDemo
    {
        static void Main(string[] args)
        {
            var participant = new Partcipant("Alice", 30);
            var (name, age) = participant;
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
