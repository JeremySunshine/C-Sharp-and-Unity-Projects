using System;
using System.Collections.Generic;
using System.Text;

namespace operatorsAssignment
{
   public class Employee
    {
        public int empID;
        


        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.empID == emp2.empID;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.empID != emp2.empID;
        }
    }
}
