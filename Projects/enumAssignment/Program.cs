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
                Console.WriteLine("Please enter the current day of the week");
                string userDay = Console.ReadLine();
                
                int DayOf = Int32.Parse(userDay);
                {
                    Console.ReadLine();
                }

                

                Console.WriteLine(DayOf);
                Console.ReadLine();
            }

            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            
        }
    }
}
