using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    struct Trainee
    {
        public int id;
        public string name;
        public float stream;
    }
    internal class Structdemo
    {
        static void Main(string[] args)
        {
            Trainee trainee = new Trainee();
            trainee.id = 101;
            trainee.name = "John Doe";
            trainee.stream = 9.5f;
        }
    }
}
