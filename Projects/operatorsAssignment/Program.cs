using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorsAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            emp1.empID = 1;
            emp2.empID = 2;
            Console.WriteLine(emp1 != emp2);
        }

    }
}
