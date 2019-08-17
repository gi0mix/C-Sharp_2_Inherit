using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Employee
{
    
partial class Employee
    {
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;
        //BUILDER  -  chained builders with the ":" operator
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay, "") { }
        public Employee(string name, int age, int id, float pay)
        {
            if (name.Length > 15)
                Console.WriteLine("Name too long, can set it");
            else
                Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }
        public Employee(string name, int age, int id, float pay, string ssn) : this(name, age, id, pay)
        {
            empSSN = ssn;
        }
    }
}
