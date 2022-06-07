using System;

namespace mainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //insatansiating mathMethods 

            mathMethods mathObject = new mathMethods();

            // creating integer to pass through

            int num1 = 10;
            Console.WriteLine(mathObject.method(num1));

            // creating second integer

            decimal num2 = 987.25m;
            Console.WriteLine(mathObject.method(num2));

            // creating string to integer

            string number = "15";
            Console.WriteLine(mathObject.method(number));
        }
    }
}
