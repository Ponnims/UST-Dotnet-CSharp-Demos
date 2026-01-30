using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class TextReaderWriterDemo
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("Textwriterdemo.txt"))
            {
                writer.WriteLine("This is done by TextWriter");
                writer.WriteLine("This is to Check how TextWriter Works");
            }
            Console.WriteLine("The file is created...check ur file");

            Console.WriteLine("The Content of the File is.....");

            using (TextReader reader = File.OpenText("Textwriterdemo.txt") )
            {
                Console.WriteLine( reader.ReadToEnd());
            }
            
        }
    }
}
