using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaAssignment
{
    class Program
    {
        public class Employee
        {
            private string name;
            private int age;
            private string designation;

            // constructor
            public  Employee(string name, int age, string designation)
            {
                this.name = name;
                this.age = age;
                this.designation = designation;
            }




            static void Main(string[] args)
            {
                List<Employee> employee = new List<Employee>();
                employee.Add("Joe", "Dirt", 1);
                employee.Add("Joe", "Swanson", 2);
                employee.Add("Peter", "Griffin", 3);
                employee.Add("Stan", "Smith", 4);
                employee.Add("Bob", "Burger", 5);
                employee.Add("Jimmy", "Pesto", 6);
                employee.Add("Sterling", "Archer", 7);
                employee.Add("Cyril", "Figgus", 8);
                employee.Add("Jeremy", "Sonnenschein", 9);
                employee.Add("Joe", "Dirt", 10);



            }
            }
        }
    }
}
