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
            Console.WriteLine(mathObject.method1(num1));

            // creating second integer

            decimal num2 = 987;
            Console.WriteLine(mathObject.method2(Convert.ToInt32(num2)));

            // creating string to integer

            string number = " 15 ";
            Console.WriteLine(mathObject.method3(Convert.ToString(number)));
        }
    }
}
