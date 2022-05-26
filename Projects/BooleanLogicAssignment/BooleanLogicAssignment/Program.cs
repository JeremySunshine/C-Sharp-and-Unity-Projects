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
            int ageINT = Convert.ToInt32(yourAge);
            Console.WriteLine("you are " + yourAge + " years of age");
            


            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            string DUI = Console.ReadLine();
            bool dui1 = Convert.ToBoolean(DUI);


            Console.WriteLine("How many speeding tickets do you have?");
            string yourTickets = Console.ReadLine();
            int ticketsINT = Convert.ToInt32(yourTickets);

            bool isQuailified = ageINT > 15 && dui1 == false && ticketsINT <= 3;
            Console.WriteLine(isQuailified);


        }
    }
}
