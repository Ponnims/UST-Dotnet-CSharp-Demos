using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvFeatures
{
    class SampleClass
    {
        public void SampleMethod()
        {
            // Local function defined within SampleMethod
            int Multiply(int x, int y)
            {
                return x * y;
            }
            int result = Multiply(3, 4);
            Console.WriteLine($"Multiplication Result: {result}");
        }
    }
    internal class LOcalFunction
    {
        static void Main(string[] args)
        {
            int Add(int a, int b)
            {
                return a + b;
            }
            void Display()
            {
                Console.WriteLine("Inside Local Function Display");
            }
            Console.WriteLine(Add(5, 10));
            Display();

            SampleClass s = new SampleClass();
            s.SampleMethod();
            
        }
    }
}
