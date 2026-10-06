/*
    * This is a program to add an employee to a list along with their salary.
    * The program is written in C#, which is a language I'm new to and working on improving via a course from Lexicon.
    * The ideas behind this include using a regular list, but then what about the corresponding salary for each employee? --> Creating an Object could be the solution.
    * 
    */

using System;
namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }

        }

        // These should potentially be removed. I see no reason for them as of right now since I initialize them in the MainMenu method.
        public string name;
        public int hourlySalary;
        

        public static bool MainMenu()
        {
            // TODO: a try-catch block in case someone does not write any of the three numbers
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Add an employee");
            Console.WriteLine("2) List all employees");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                string name = Console.WriteLine("Employee name: "); // I don't get the issue... CS0029
                Console.ReadLine();
                string hourlySalaryString = Console.WriteLine("Hourly Salary: "); // I don't get the issue... CS0029
                int hourlySalary = int.Parse(hourlySalaryString);
                AddEmployee(name, hourlySalary); // Can't figure out the logic here. It makes sense to me to add both name and salary. Have to read up on dictionaries
                return true;
            }
            else if (result == "2")
            {
                ListAllEmployees(); // Don't get the issue... CS0120
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        // Option 1 has been chosen - AddEmployee is called
        //TODO: Figure out how to add the salary to the employee. Maybe a dictionary instead of array would be a better choice. 
        // Think I found it. I have to use constructors. Great playlist: https://app.pluralsight.com/ilx/video-courses/d7680953-feb2-48a0-8f74-4d3185346656/e475012f-fc25-4a91-9cbc-39aad8c54c1b/bbff7ed1-3abb-466f-862d-db29d6c7beb4
        public string[] AddEmployee(string employeeName)
        {

            // Doumentation recommends writing the array as: var a = System.Array.Empty<int>();
            string[] employeeList = {};
            bool isInList = employeeList.Contains(employeeName);
            if (!isInList)
            {
                employeeList.Append(employeeName);
            }

            return employeeList;
            
        }

        // Option 2 has been chosen
        public string[] ListAllEmployees() 
        {
            return employeeList; //This doesn't work since it is declared in the AddEmployee-method, but I can't seem to write it up with name and hourlySalary
        }

        // Started the day with this, but it feels rather unnecessary. I'll remove for now.
        /*
        public class Employee
        {
            public string name;
            public int salary;

            // TODO: Check if the properties are needed, if not remove them
            public string Name { get; set; } = string.Empty;
            
            public int Salary { get; set; }

            public String[] Employees(String[] employeesArray)
            {
                String[] employees;
                employees = employeesArray.Append("Employee").ToArray();
                return employees;
            }
        }*/

    }
}
