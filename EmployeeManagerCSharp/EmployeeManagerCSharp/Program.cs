﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager emp1 = new Manager(123, "Bob");
            //Console.WriteLine(emp1.PrintDetails());
            Employee emp2 = new Employee(234, "Zac");
            Employee emp3 = new Employee(345, "Deb");
            emp1.AddEmployee(emp2);
            emp1.AddEmployee(emp3);
            Console.WriteLine(emp1.PrintDetails());
            Console.ReadLine();
        }
    }
}
