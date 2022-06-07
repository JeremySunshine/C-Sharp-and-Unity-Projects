using System;
using System.Collections.Generic;
using System.Text;

namespace mainMethodAssignment
{
    class mathMethods
    {
        // Creating first math operatiion
        public int method(int number)
        {
            return number + 10;
        }

        // Creating second math operation

        public int method(decimal number2)
        {
            return Convert.ToInt32(number2) + 0;
        }

        public int method(string number3)
        {
            return Convert.ToInt32(number3) + 15;
        }
    }
}
