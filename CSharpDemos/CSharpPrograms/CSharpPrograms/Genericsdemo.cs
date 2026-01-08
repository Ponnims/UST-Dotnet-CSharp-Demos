using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{

    class MyGenericClass<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }

        public void Display(T first)
        {
            Console.WriteLine(first);
        }
    }

    internal class Genericsdemo
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> intobj= new MyGenericClass<int>();
            intobj.Id = 101;
            intobj.Name = "Hello Generics";
            intobj.Display(1000);

            MyGenericClass<string> strobj= new MyGenericClass<string>();
            strobj.Id = "A101";
            strobj.Name = "Hello Generics";
            strobj.Display("Hello World");
        }
    }
}
