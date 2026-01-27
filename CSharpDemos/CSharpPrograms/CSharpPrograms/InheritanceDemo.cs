using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{


    class Employeee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public void Work()
        {
            Console.WriteLine("Employee is working.");
        }
    }

    class Manager : Employeee
    {
        public void ConductMeeting()
        {
            Console.WriteLine("Manager is conducting a meeting.");
        }
    }

    class Developer : Employeee
    {
        public void WriteCode()
        {
            Console.WriteLine("Developer is writing code.");
        }
    }
    internal class InheritanceDemo
    {
        static void Main(string[] args)
        {
            Employeee dev = new Developer();
            Employeee mgr = new Manager();

          //  Manager newmgr = new Employeee();


        }

    }
}
