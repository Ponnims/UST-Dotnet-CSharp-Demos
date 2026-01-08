using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class StringStringBuilderdemo
    {
        static void Main(string[] args)
        {
            string somevalue= "Hi Hello ";
            somevalue += "Welcome to C# Programming";

            Console.WriteLine(somevalue);

            StringBuilder sb = new StringBuilder("Hi Hello ");
            sb.Append("Welcome to C# Programming");
            sb.Append(" Enjoy your learning!");

            sb.Replace("C#","CSharp");
            Console.WriteLine(sb.ToString());
        }
    }
}
