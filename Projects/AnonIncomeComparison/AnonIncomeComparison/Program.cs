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

            Console.WriteLine("What is your hourly rate?");
            string hourlyRate1 = Console.ReadLine();
            int hourINT = Convert.ToInt16(hourlyRate1);

            Console.WriteLine("How many hours do you work per week?");
            string weekHours1 = Console.ReadLine();
            int weekINT = Convert.ToInt32(weekHours1);

            Console.WriteLine("Person 2");

            Console.WriteLine("What is your hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            int hourINT2 = Convert.ToInt16(hourlyRate2);

            Console.WriteLine("How many hours do you work per week?");
            string weekHours2 = Console.ReadLine();
            int weekINT2 = Convert.ToInt32(weekHours1);

            Console.WriteLine("Person 1 Annual Salary");
            int num1 = 52;
            int product1 = hourINT * weekINT * num1;
            Console.WriteLine(product1);
            Console.ReadLine();

            Console.WriteLine("Person 2 Annual Salary");
            int num2 = 52;
            int prodcut2 =  hourINT2 * weekINT2 * num2;
            Console.WriteLine(prodcut2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more than Person 2?");
            int person1 = product1;
            int person2 = prodcut2;
            bool moreMoney = product1 > prodcut2;
            Console.WriteLine(moreMoney);
            Console.ReadLine();




















        }
    }
}
