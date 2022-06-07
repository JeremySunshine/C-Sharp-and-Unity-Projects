using System;

namespace methodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate class
            methods mathOpp = new methods();
            

           

            // asking user for num1
            Console.WriteLine("Plese input a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //asking user for num2
            Console.WriteLine("Plese input a second number if you would like: "); 
            string userInputString = Console.ReadLine();
            if ( userInputString == "")
            {
                Console.WriteLine(mathOpp.parameters(userInput));
            }
            else
            {
                int userInputInt = Convert.ToInt32(userInputString);
                Console.WriteLine(mathOpp.parameters(userInput, userInputInt));
            }
            Console.ReadLine();

        }
    }
}
