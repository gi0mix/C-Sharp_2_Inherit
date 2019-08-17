  using System;

namespace _02_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Exploring the details of Inheritance ***");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
            
        }
    }
}
