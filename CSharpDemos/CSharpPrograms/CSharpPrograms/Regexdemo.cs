using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpPrograms
{
    internal class Regexdemo
    {
        static void sample()
        {
            string inputemail = "hjg@hjg.com";
        }
        static void Main(string[] args)
        {
            // create the regular expression or pattern
            // we can match that pattern with our value
            // which returns boolean value true/false
            // based on that we can perform validation

            string inputmobileno= "8234567890";
            Regex mobilenopattern = new Regex(@"[6789]\d{9}");

            if(mobilenopattern.IsMatch(inputmobileno))
            {
                Console.WriteLine($"{inputmobileno} is valid mobile number");
                sample();
            }
            else
            {
                Console.WriteLine($"{inputmobileno} is invalid mobile number");
            }
        }
    }
}

// step into F11
// step over