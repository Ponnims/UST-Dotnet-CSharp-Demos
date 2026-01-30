using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class FileDemo
    {
        static void Main(string[] args)
        {
            //File is a class in System.IO namespace
            // Exists, Create, Delete, Copy, Move, ReadAllText, WriteAllText etc are some methods of File class.

            if(File.Exists("DemoFile.txt"))
            {
                Console.WriteLine("File already exists.");
            }
            else
            {
                // Create a file
                File.Create("DemoFile.txt");
                Console.WriteLine("File created successfully.");
            }

            // Write text to the file
            File.WriteAllText("DemoFile.txt", "Hello, this is a demo file. Lets Learn File Concepts");
            Console.WriteLine("Text written to the file successfully.");

            // Read text from the file
            string content = File.ReadAllText("DemoFile.txt");
            Console.WriteLine($"Content of the file: {content}");

            //copy the file
            //string from_Path= @"C:\Check\DemoFile.txt";
            //string to_Path= @"C:\Check\chk.txt";
            //File.Copy(from_Path,"newfile.txt");
            //Console.WriteLine("Copied...");

            // Delete the file
            File.Delete("newfile.txt");
            Console.WriteLine("File deleted successfully.");
        }
    }
}
