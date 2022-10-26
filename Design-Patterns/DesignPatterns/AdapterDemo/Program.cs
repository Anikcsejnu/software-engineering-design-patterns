using AdapterDemo.Adapter;
using AdapterDemo.Target;
using System;

namespace AdapterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp = new EmployeeAdapter();
            string value = emp.GetAllEmployees();
            Console.WriteLine(value);
        }
    }
}
