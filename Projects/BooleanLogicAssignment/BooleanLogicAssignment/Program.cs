using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int age = 15;
            Console.WriteLine("you are " + yourAge + " years of age");
            


            Console.WriteLine("Have you ever had a DUI?");
            string yourDUI = Console.ReadLine();
            Console.WriteLine();


            Console.WriteLine("How many speeding tickets do you have?");
            string yourTickets = Console.ReadLine();

            bool isQaulify = (yourAge == "15" && yourDUI == "false" && yourTickets == "3");




            



        }
    }
}
