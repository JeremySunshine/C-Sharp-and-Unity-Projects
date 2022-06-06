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
            //Part 1
            String[] cars = { "BMW", "Mustang", "Corvette" };
            Console.WriteLine("Enter some text to appened to my car names");
            


            string userInput = Console.ReadLine();
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = cars[i] + userInput;
            }
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            
            
            Console.ReadLine();

            Console.WriteLine("Enter you age: ");
            string age = Console.ReadLine();

            // Part 2 fixed infinite loop
            while (age == "") 
            {
                Console.Write("Enter Your age: ");
                age = Console.ReadLine();
            }

            int[] testScores = { 85, 81, 69, 91, 100, 77, 85, 73 };
            // Part 3 < 
            for (int i = 0; i < testScores.Length; i++)
            {
                
                
                    Console.WriteLine("Passing test Scores: " + testScores[i]);
                
            }
            Console.ReadLine();

            // Part 3 <=
            int[] testScores2 = { 85, 81, 69, 91, 100, 77, 85, 73 };

            for (int f = 0; f <= testScores2.Length - 1; f++)
            {
                
                
                    Console.WriteLine("Failing test Scores: " + testScores2[f]);
                
            }

            Console.ReadLine();


            Console.WriteLine("See if your number is on the list ");
            
            // Part 4 
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
            

            string favNum = Console.ReadLine();
            

            for (int n = 0; n < number.Count; n++)
            {
                if (!number.Contains(favNum))
                {
                    Console.WriteLine("The string you choose is not in the list.");
                    break;
                }
                if (favNum == number[n])
                {
                    Console.WriteLine(n);
                    break;
                    
                }

            }
 
            Console.ReadLine();

            // Part 5 
            List<string> names = new List<string> { "Jeremy", "Jeremy", "Skyla", "Sloan" };
            Console.WriteLine("Enter a name to search");
            string userInput2 = Console.ReadLine();
            for (int i = 0; i < names.Count; i++)
            {
                if (!names.Contains(userInput2))
                {
                    Console.WriteLine("The string you choose is not in the list.");
                    break;
                }
                if (userInput2 == names[i])
                {
                    Console.WriteLine(i);
                    

                }
            }
            Console.ReadLine();
            // Part 6 
            List<string> dupeList = new List<string>();
            foreach (string nick in names)
            {
                if (dupeList.Contains(nick))
                {
                    Console.WriteLine(nick + " is a duplicate");
                }
                else
                {
                    Console.WriteLine(nick + " has not been seen yet");
                    dupeList.Add(nick);
                }
                
            }
            Console.ReadLine();

        }
    }
}
