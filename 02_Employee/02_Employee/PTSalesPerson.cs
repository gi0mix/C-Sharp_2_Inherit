using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Employee
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empID, currPay, ssn, numbOfSales)
        { }

    }
}
