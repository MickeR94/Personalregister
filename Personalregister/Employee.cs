using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Personalregister
{
    internal class Employee
    {
        public string fullName;
        public int monthlySalary;

        public Employee(string name, int salary)
        {
            name = this.fullName;
            salary = this.monthlySalary;
        }

        public void addEmployee(string addName, int addSalary)
        {
            fullName = addName; //= Employee.name;
            monthlySalary = addSalary; //= Employee.salary;

        }

        public string listEmployees()
        {
            return Employee; // TODO: Figure out how to show all employees. Perhaps a list that stores all Employee-objetcs
        }
        
    }
}
