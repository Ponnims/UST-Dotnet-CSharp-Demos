using EXtensionMethods;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvFeatures
{
    internal class ExtensionMethodDemo
    {
        static void Main(string[] args)
        {
           // string myname = "   John Doe   ";
             int[] scores= { 90, 85, 78, 92, 88 };
            string email = "msp@gmail.com";
            string myname = "   John Doe   ";
            string lnguage = "malayalam";

            int number = 50;
            number.IsOddOrEven();
            scores.GetAverage();
            email.IsValidEmail();
            myname.TrimAndConvertToUpper();
            lnguage.IsPalindrome();






            Console.WriteLine($"The number {number} is {number.IsOddOrEven()}");
            Console.WriteLine($"The average score is {scores.GetAverage()}");
            Console.WriteLine($"Is the email '{email}' valid? {email.IsValidEmail()}");
            Console.WriteLine($"Trimmed and uppercased name: '{myname.TrimAndConvertToUpper()}'");
            Console.WriteLine($"Is the language '{lnguage}' a palindrome? {lnguage.IsPalindrome()}");



        }
    }
}
