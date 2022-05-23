using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonIncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();

            int hourlyRate1 = 15;
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine(hourlyRate1);
            Console.ReadLine();

            int hoursPerWeek1 = 40;
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(hoursPerWeek1);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();

            int hourlyRate2 = 20;
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine(hourlyRate2);
            Console.ReadLine();

            int hoursPerWeek2 = 40;
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(hoursPerWeek2);
            Console.ReadLine();

            int annualSalary1 = 31200;
            Console.WriteLine("Person's 1 annual Salary: ");
            Console.WriteLine(annualSalary1);
            Console.ReadLine();

            int annualSalary2 = 41600;
            Console.WriteLine("Person's 2 annual Salary: ");
            Console.WriteLine(annualSalary2);
            Console.ReadLine();

            bool trueOrFalse = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();











        }
    }
}
