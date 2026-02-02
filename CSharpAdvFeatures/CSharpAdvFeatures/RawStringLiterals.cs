using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvFeatures
{
    internal class RawStringLiterals
    {
        static void Main(string[] args)
        {
            string jsondata = """
{
    "name": "John Doe",
    "age": 30,
    "isEmployee": true,
    "skills": [
        "C#",
        "ASP.NET",
        "SQL"
    ]
}

""";

            Console.WriteLine("JSON Data:");
            Console.WriteLine(jsondata);
        }
    }
}
