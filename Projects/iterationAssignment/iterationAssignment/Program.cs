using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //one dimensional array
            String[] cars = { "BMW", "Mustang", "Corvette" };

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);

            Console.ReadLine();

            
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " I hope your day is going well");
            Console.ReadLine();

            Console.WriteLine("Enter you age: ");
            string age = Console.ReadLine();

            while (age == "")
            {
                Console.Write("Enter Your age: ");
                age = Console.ReadLine();
            }

            int[] testScores = { 85, 81, 69, 91, 100, 77, 85, 73 };

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > 80)
                {
                    Console.WriteLine("Passing test Scores: " + testScores[i]);
                }
            }
            Console.ReadLine();

            int[] testScores2 = { 85, 81, 69, 91, 100, 77, 85, 73 };

            for (int f = 0; f < testScores2.Length; f++)
            {
                if (testScores2[f] < 80)
                {
                    Console.WriteLine("Failing test Scores: " + testScores2[f]);
                }
            }

            Console.ReadLine();


            Console.WriteLine("See if your number is on the list ");
            

            List<string> number = new List<string>();
            number.Add("1");
            number.Add("2");
            number.Add("3");
            number.Add("4");
            number.Add("5");
            number.Add("6");
            number.Add("7");
            number.Add("8");
            number.Add("9");
            number.Add("10");
            

            int favNum = Convert.ToInt32(Console.ReadLine());
            

            for (int n = 0; n < number.Count; n++)
            {
                if (favNum > 10)
                {
                    Console.WriteLine("Try a number between 1 and 10");
                    favNum = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine(favNum);

            Console.ReadLine();


            String[] names = { "Jeremy", "Jeremy", "Skyla", "Sloan" };

            foreach (string nick in names)
            {
                Console.WriteLine(nick);
            }
            Console.ReadLine();

            

        }
    }
}
