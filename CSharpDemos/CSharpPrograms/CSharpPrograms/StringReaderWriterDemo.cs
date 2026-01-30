using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class StringReaderWriterDemo
    {
        static void Main(string[] args)
        {
            StringBuilder sb= new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            sw.Write("This is a demo on StringWriter and StringReader");
            sw.Flush();
            sw.Close();

            StringReader sr = new StringReader(sw.ToString());
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
