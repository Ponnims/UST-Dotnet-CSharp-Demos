using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{

    class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public double Empsalary { get; set; }
        public string Designation { get; set; }
    }
    internal class Initializerdemo
    {
        static void Main(string[] args)
        {
            List<int> scores= new List<int>() { 90, 80, 70, 60, 50 }; // Collection Initializer
            List<string> empnames= new List<string>() { "Msp", "Raja", "Sai" }; // Collection Initializer


            Employee emp = new Employee() {Designation="Developer",Empid=100, Empname="Msp", Empsalary=45000 }; // Object Initializer
            //emp.Empid = 101;
            //emp.Empname = "Msp";
            //emp.Empsalary = 45000;
            //emp.Designation = "Developer";

            // Collection of Objects.
            List<Employee> emplist = new List<Employee>()
            {
               new Employee(){Empid=100,Empname="MSP",Empsalary=2332534,Designation="Consultant" },
               new Employee(){Empid=101,Empname="RAJA",Empsalary=150000,Designation="Developer" },
               new Employee(){Empid=102,Empname="SAI",Empsalary=120000,Designation="Tester" }
            };
           



            }
    }
}
