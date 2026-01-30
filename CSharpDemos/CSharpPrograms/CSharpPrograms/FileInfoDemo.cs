using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class FileInfoDemo
    {
        static void Main(string[] args)
        {
            FileInfo fileinfo = new FileInfo("DemoFileStream.txt");

            Console.WriteLine(fileinfo.FullName);
            Console.WriteLine(fileinfo.Name);
            Console.WriteLine(fileinfo.CreationTime);
            Console.WriteLine(fileinfo.Extension);
            Console.WriteLine(fileinfo.DirectoryName);
            Console.WriteLine(fileinfo.Length);
            Console.WriteLine(fileinfo.LastWriteTimeUtc);
        }
    }
}
