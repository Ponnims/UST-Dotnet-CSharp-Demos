using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{

    public delegate void MyDelgate(int firstnum, int secnum);

    class DelegateSample
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Diff(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public void Product(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }


    internal class DelegateDemo
    {
        static void Main(string[] args)
        {
            DelegateSample ds = new DelegateSample();
            MyDelgate delobj = new MyDelgate(ds.Add);
            delobj += ds.Diff;
            delobj += ds.Product;

            delobj(10, 2);
        }
    }
}

// int num=10;
// int *ptr;
// ptr= &num;

