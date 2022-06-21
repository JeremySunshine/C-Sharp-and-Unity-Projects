using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaAssignment
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { firstName = "Joe", lastName = "Dirt", ID = 1},
                new Employee { firstName = "Joe", lastName = "Swanson", ID = 2},
                new Employee { firstName = "Bob", lastName = "Belcher", ID = 3},
                new Employee { firstName = "Jimmy", lastName = "Pesto", ID = 4},
                new Employee { firstName = "Sterling", lastName = "Archer", ID = 5},
                new Employee { firstName = "Cyril", lastName = "Figgus", ID = 6},
                new Employee { firstName = "Jeremy", lastName = "Sonnenschein", ID = 7},
                new Employee { firstName = "Eric", lastName = "Cartman", ID = 8},
                new Employee { firstName = "Stan", lastName = "Marsh", ID = 9},
                new Employee { firstName = "Kenny", lastName = "McCormick", ID = 10}
            };

            List<Employee> Joe1 = new List<Employee>();
            
            
            foreach (Employee emp in employees)
            {
                if (emp.firstName == "Joe")
                {
                    Joe1.Add(emp);
                }
            }

            foreach (Employee emp in Joe1)
            {
                Console.WriteLine("{0} {1} {2}", emp.firstName, emp.lastName, emp.ID);

            }
            List<Employee> Joe2 = employees.Where(x => x.firstName == "Joe").ToList();

            List<Employee> empID = employees.Where(x => x.ID > 5).ToList();
        }
    }
    
    
}
