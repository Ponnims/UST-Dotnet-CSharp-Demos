using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CSharpAdvFeatures
{
    internal class NullableReferenceTypes
    {
        static void Main(string[] args)
        {
            string? myname = null;
            if(myname == null)
            {
                Console.WriteLine("myname is null, assigning a value.");
                myname = "John Doe";
            }
            Console.WriteLine($"My name is {myname.Length} characters long.");
        }


    }
}
