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
            String[] cars = { "Ford", "GMC", "BMW", "lamborghini" };
            Console.WriteLine("Select an index between 0 - 3");

           
            int index = Convert.ToInt32(Console.ReadLine());

            if (index > 3)
            {
                Console.WriteLine("That number is not in the index, please select an index between 0-3");
                index = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(cars[index]);

            Console.ReadLine();


            

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine("Select an index 0-5 to determine your lucky number");

            int index2 = Convert.ToInt32(Console.ReadLine());

            if (index2 > 5)
            {
                Console.WriteLine("That number is not in the index, please select an index between 0-5");
                index2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(luckyNumbers[index]);


            Console.ReadLine();
            



            



            Console.WriteLine("Please select an index between 0-4");


            List<string> food = new List<string>();
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            int index3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(food[index3]);





        }
    }
}
