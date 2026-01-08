using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class Collectionsdemo
    {
        static void Main(string[] args)
        {
            int[] Scores = new int[5] { 90, 80, 70, 60, 50 };
            //Scores[3]= "hello"; // Error 
            // It can accept only integers, Type Safe

            //Collections
            // 1. Non Generic Collections - Not Type Safe, Every time boxing and unboxing happens
            // performance is lower
            // ArrayList, Hashtable, Stack, Queue

            // 2. Generic Collections - Type Safe
            // performance is better
            // List<T>, Dictionary<TKey,TValue>, Stack<T>, Queue<T>

            ArrayList listofdetails = new ArrayList();
            listofdetails.Add(100); // int
            listofdetails.Add("hello"); // string
            listofdetails.Add(99.99); // double
            listofdetails.Add(true); // bool


            int sum = 0;
            foreach(object item in listofdetails)
            {
                //  Console.WriteLine(item);
               // sum +=(int) item; // not type safe, unboxing may throw exception
            }

            Hashtable ht= new Hashtable();
            ht.Add(1, "Msp");
            ht.Add(2, "Raja");
            ht.Add(3, 2000);
            ht.Add(4, 99.99);
            ht.Add(5, true);

            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
            }

            Stack stack= new Stack(); //LIFO
            stack.Push(100);    
            stack.Push("hello");
            stack.Push(99.99);
            stack.Push(true);

            
            Console.WriteLine($"The popped element is{stack.Peek()}");
            Console.WriteLine("After Peeking");
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine($"The popped element is {stack.Pop()}");
            Console.WriteLine("After Popping");
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }


            Queue queue= new Queue(); //FIFO

            queue.Enqueue(100);
            queue.Enqueue("hello");
            queue.Enqueue(99.99);
            queue.Enqueue(true);

            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();
            queue.Peek();


            // Generic Collections
            List<int> listofscores = new List<int>();
            listofscores.Add(100);
            listofscores.Add(200);
            //listofscores.Add("hello"); // Error//  it is type safe // compile time type cheching


            Dictionary<int, string> dict= new Dictionary<int, string>();
            dict.Add(1, "Msp");
            dict.Add(2, "Raja");
            dict.Add(3, "Hello");
            dict.Add(4, "World");
            dict.Add(5, "Generics");
           // dict.Add(7, 200); // Error

            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Stack<bool> boolstack= new Stack<bool>();
            boolstack.Push(true);
            boolstack.Push(false);
            boolstack.Push(true);

            foreach (bool item in boolstack)
            {
                Console.WriteLine(item);
            }

            Queue<string> stringqueue= new Queue<string>();
            stringqueue.Enqueue("Hello");
            stringqueue.Enqueue("World");
            stringqueue.Enqueue("Generics");

            foreach (string item in stringqueue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
