using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class Valuetypereftype
    {
        static void Main(string[] args)
        {
            int val1 = 100; // value type
            int val2 = val1;
            val2 = 200;
            Console.WriteLine($"Value Type:Value1 :  {val1}, Value 2 : {val2}");


            int[] arr1 = { 1, 2, 3 }; // reference type
            int[] arr2 = arr1;
            arr2[0] = 100;
            Console.WriteLine($"Reference Type:Array1 :  {arr1[0]}, Array 2 : {arr2[0]}");
        }
    }
}
