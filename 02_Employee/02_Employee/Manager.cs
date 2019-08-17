using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Employee
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }
        public Manager() {}
        public Manager(string fullName, int age, int id, float currPay, string ssn, int numbOfOpts) : base(fullName, age, id, currPay)
        {
            StockOptions = numbOfOpts;
        }
    }
}
