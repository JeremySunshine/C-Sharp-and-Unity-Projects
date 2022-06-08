using System;

namespace methodsANDobjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeName = new Employee();
            {
                employeeName.fName = "Sample";
                employeeName.Lname = "Student";
                employeeName.sayName();

            }
            
        }
    }
}
