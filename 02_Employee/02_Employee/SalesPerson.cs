using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Employee
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }
        public SalesPerson() { }
        public SalesPerson(string name, int age, int id, float currPay, string ssn, int numbOfSales) : base(name, age, id, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }
    }
}
