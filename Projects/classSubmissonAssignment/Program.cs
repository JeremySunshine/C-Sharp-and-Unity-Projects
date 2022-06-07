using System;

namespace classSubmissonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //method overloading

            double total;

            total = Multiply(2, 3, 4);

            Console.WriteLine(total);
            Console.ReadLine();

        static double Multiply( double a, double b)
            {
                return a * b;
            }

        static double Multiply(double a, double b, double c)
            {
                return a * b * c;
            }



            // instantiate the class
            division divideBy = new division();

            // asking user to input a number
            Console.WriteLine("Please enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(divideBy.myMethod(userNumber));


          
        }
    }
}
