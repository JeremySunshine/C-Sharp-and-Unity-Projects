using System;
using System.Collections.Generic;

namespace parametersAssignment
{
    class Program 
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string> { things = new List<string> { "Jeremy", "Skyla", "Sloan" } };
            Employee<int> employeeInt = new Employee<int> { things = new List<int> { 28, 25, 2 } };
            foreach (string emp in employee.things)
            {
                Console.WriteLine(emp);
            }
            
        }
    }
}
