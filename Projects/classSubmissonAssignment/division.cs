using System;
using System.Collections.Generic;
using System.Text;

namespace classSubmissonAssignment
{
    class division
    {
        // creating method
        public void myMethod(int number )
        {
            int z = number / 2;
            Console.WriteLine(z);
        }

        //method overloading and also using out parameter

        public void myMethod(out int number)
        {
            number = 22;

        }
    }
}
