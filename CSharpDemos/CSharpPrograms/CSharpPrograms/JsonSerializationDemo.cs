using System;
using System.Collections.Generic;
using System.Text.Json;

namespace CSharpPrograms
{
    internal class JsonSerializationDemo
    {
        static void Main(string[] args)
        {
            Student std = new Student() {Id=1, Name="John Doe", Course="Computer Science" };

            string jsonString = JsonSerializer.Serialize(std);
            Console.WriteLine(jsonString);

            File.WriteAllText("student.json", jsonString);


           Student deserializedstudent= JsonSerializer.Deserialize<Student>(jsonString);

            Console.WriteLine(deserializedstudent.Id);
            Console.WriteLine(deserializedstudent.Name);
            Console.WriteLine(deserializedstudent.Course);
        }
    }
}
