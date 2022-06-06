using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            mathOpp mathObject = new mathOpp();
            Console.WriteLine("What number would you like to do math operations on?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mathObject.method1(userInput));
            Console.WriteLine(mathObject.method2(userInput));
            Console.WriteLine(mathObject.method3(userInput));



        }
        

       
    }
}
