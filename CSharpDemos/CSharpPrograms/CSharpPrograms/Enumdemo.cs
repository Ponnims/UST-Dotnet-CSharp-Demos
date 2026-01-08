using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    public enum RGB
    {
        Red,
        Green,
        Blue
    }
    internal class Enumdemo
    {
        static void Main(string[] args)
        {
            // getnames, getvalues are the two static methods of Enum class

            string[] colors= Enum.GetNames(typeof(RGB));
            int[] colorvalues = (int[])Enum.GetValues(typeof(RGB));

            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }

            foreach(int colorvalue in colorvalues)
            {
                Console.WriteLine(colorvalue);
            }
        }
    }
}
