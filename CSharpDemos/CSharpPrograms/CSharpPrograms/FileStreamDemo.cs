using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class FileStreamDemo
    {
        //FileStream is a class in System.IO namespace
        // It is used to read from and write to files as a stream of bytes.
        // FileModes: Append, Create, CreateNew, Open, OpenOrCreate, Truncate
        // Create mode is used to create a new file. If the file already exists, it will be overwritten.
        //CReateNew mode is used to create a new file. If the file already exists, an IOException will be thrown.

        //StreamWriter and StreamReader are used to write and read text data to and from files respectively.
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("DemoFileStream.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("Hello, this is a demo file using FileStream.");
            sw.WriteLine("Lets Learn FileStream Concepts.");
            sw.WriteLine("FileStream allows reading and writing bytes to files.");
            sw.Close();
            fs.Close();
            Console.WriteLine("File created successfully.");


            using (FileStream fs1 = new FileStream("DemoFileStream.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs1))
                {
                    var result = sr.ReadToEnd();
                    Console.WriteLine($"The Content of the file is\n {result}");
                }
            }
               
            
            
        }

      

    }
}
