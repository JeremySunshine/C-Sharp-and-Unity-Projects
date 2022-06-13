using System;

namespace methodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class 
            math mathOpp = new math();

            mathOpp.Multiply();
            mathOpp.Multiply(5, 6);
            
        }
    }
}
