using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints current time to console
            Console.WriteLine(DateTime.Now);

            // ask user for input 
            Console.WriteLine("Please input a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            DateTime timeNow = DateTime.Now;
            DateTime future = timeNow.AddHours(userInput);
            

            //prints to console exact time in x hours
            Console.WriteLine("In " + userInput + " it will be " + future);
            
            

        }
    }
}
