using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class SimpleExceptionDemo
    {
        static void Main(string[] args)
        {
            //int a, b, result;
            //Console.WriteLine("Enter two integers:");
            //a= Convert.ToInt32(Console.ReadLine());
            //b= Convert.ToInt32(Console.ReadLine());
            //if(b==0)
            //{
            //    Console.WriteLine("Division by zero is not allowed.");
            //    return;
            //}
            
            //result = a / b;
            //Console.WriteLine($"The result of {a} divided by {b} is {result}");


            int chk = 2147483647;
            //int chk1 = 2147483648;

            try
            {
                int a, b, result;
                Console.WriteLine("Enter two integers:");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                result = a / b;
                Console.WriteLine($"The result of {a} divided by {b} is {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format. Please enter valid integers.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }

            Console.WriteLine("This is the end of the program.");
        }

    }
}
