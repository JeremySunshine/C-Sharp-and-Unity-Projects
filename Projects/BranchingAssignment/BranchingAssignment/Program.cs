using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Exprees. Please follow the Instructions below!");

            Console.WriteLine("Please enter your package weight:");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package express have a good day!");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int pkgWidth = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Please enter the package height:");
                int pkgHeight = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Please enter the package length:");
                int pkgLength = Convert.ToInt32(Console.ReadLine());
                if (pkgWidth + pkgHeight + pkgLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package express have a good day!");
                }
                else
                {
                    int totalCost = pkgWidth * pkgHeight * pkgLength * pkgWeight / 100;
                    Console.WriteLine("Youre estimated total shipping for this package is : $" + totalCost);
                    Console.ReadLine();

                }
               
            }



            
            
           
            }

        }
    }

