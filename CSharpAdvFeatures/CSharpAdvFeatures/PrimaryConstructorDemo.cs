using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvFeatures
{
    class Learner
    {
        public int LearnerId { get; set; }
        public string LearnerName { get; set; }
        public Learner(int id, string name)
        {
            LearnerId = id;
            LearnerName = name;
        }
    }

    class Student(int id, string name,int score)
    {
        public int Id=> id;
        public string Name=> name;

        public int Score { get; set; } = score;
    }

    internal class PrimaryConstructorDemo
    {
        static void Main(string[] args)
        {
            Student std= new Student(101, "John", 95);
            Console.WriteLine($"Student ID: {std.Id}, Name: {std.Name}, Score: {std.Score}");
            std.Score = 98;
            Console.WriteLine("After Modification of the score");
            Console.WriteLine($"Student ID: {std.Id}, Name: {std.Name}, Score: {std.Score}");

           // std.Id = 200; // This line will cause a compile-time error because Id is read-only
           //std.Name="Doe"; // This line will cause a compile-time error because Name is read-only
        }
    }
}
