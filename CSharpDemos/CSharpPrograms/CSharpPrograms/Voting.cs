using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class Voting
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new NotEligleForVotingException("Age must be 18 or older to vote.");
            }
            else
            {
                Console.WriteLine("You are eligible to vote.");
            }
        }
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            try
            {
                ValidateAge(age);
            }
            catch(NotEligleForVotingException ex)
            {
                
                Console.WriteLine("Voting Eligibility Error: " + ex.Message);
                var errordetails = $"This error is raised at {DateTime.Now} and" +
                    $"This error happend in the method {ex.Source}";
                // log the error message into a file.
                // Errorlogging.logerror("pass the details of the exception
                // so that the developer can refer it later ");
                ErrorLogging.LogError($"Error logged : {errordetails}");

            }
            finally
            {
                Console.WriteLine("Thank you for using the voting eligibility checker.");
            }

            Console.WriteLine("All Done");
        }
    }
}
