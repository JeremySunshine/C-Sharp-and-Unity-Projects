using System;

namespace polymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable Quitter = new Employee();
            Quitter.Quit();
        }
    }
}
