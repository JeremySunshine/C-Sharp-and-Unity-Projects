using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumAssignment
{
    class Program
    {
        enum DayofTheWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            try
            {
                //Asking user to enter a day of the week
                Console.WriteLine("Please enter the current day of the week 1-7?");
                string userDay = Console.ReadLine();

                DayofTheWeek day = (DayofTheWeek)Convert.ToInt32(userDay);

                Console.WriteLine(day);
                Console.ReadLine();
            }

            catch
            {
                Console.WriteLine("Please use the numbers 1- 7");
            }
            
        }
    }
}
