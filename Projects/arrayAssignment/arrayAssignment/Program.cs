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
            Console.WriteLine(cars[index]);
            Console.ReadLine();


            

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            Console.Write("Select an index 0-5 to determine your lucky number");
            string index2 = luckyNumbers.ToString();
            Console.WriteLine(luckyNumbers[index]);
            Console.ReadLine();
            



            



            Console.WriteLine("Please slect aan index b;tween 0-4");

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
