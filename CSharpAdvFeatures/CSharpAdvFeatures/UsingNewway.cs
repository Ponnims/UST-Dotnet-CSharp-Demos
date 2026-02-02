using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvFeatures
{
    internal class UsingNewway
    {
        static void Main(string[] args)
        {
            // Using 'using' declaration to simplify resource management
            // Auto-dispose at the end of the scope
            // Old way
            //using (var reader = new System.IO.StreamReader("sample.txt"))
            //{
            //    string content = reader.ReadToEnd();
            //    Console.WriteLine("File Content using old way:");
            //    Console.WriteLine(content);
            //}

            using var reader = new System.IO.StreamReader("sample.txt");
            string content = reader.ReadToEnd();
            Console.WriteLine("File Content using new way:");
            Console.WriteLine(content);
        }
    }
}
