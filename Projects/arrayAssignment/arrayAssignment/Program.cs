using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayAssignment
{
    class Program
    {
        static void Main()
        {
            string[] cars = { "Ford, BMW, Nissan, GMC" };
            Console.WriteLine("Please type in a car brand");
            Console.ReadLine();

            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
            Console.WriteLine("Please select a number between 0-5");
            string userNum = Console.ReadLine();
            int userNum1 = Convert.ToInt32(userNum);
            if (userNum1 > 5)
            {
                Console.WriteLine(userNum1 + " Is not an index");

            }



            Console.WriteLine("Please slect aan index between 0-4")
            List<int> intlist = new List<int>();
            intlist.Add(5);
            intlist.Add(10);
            intlist.Add(15);
            intlist.Add(20);
            intlist.Add(25);
            string userNum2 = Console.ReadLine();
            int userNum2 = Convert.ToInt32(userNum);


            Console.WriteLine(intlist + userNum2);
        }
    }
}
