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
            int userInput2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(mathOpp.parameters(userInput2));
            Console.WriteLine(mathOpp.parameters(userInput2));



        }
    }
}
