using System;

namespace classSubmissonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // instantiate the class
            division divideBy = new division();

            // asking user to input a number
            Console.WriteLine("Please enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            divideBy.myMethod(userNumber);

            //method overloading and also using out parameter
            int number = 0;
            Console.WriteLine(number);
            divideBy.myMethod(out number);
            Console.WriteLine(number);

            // calling myStatic Class method

            myStaticclass.myStaticMehtod();
            Console.ReadLine();


        }
    }
}
