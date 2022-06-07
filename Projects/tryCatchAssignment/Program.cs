using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Create a list of integers

                int[] numbers = { 6, 10, 14, 16, 20 };

                // Ask user for number to divide by

                Console.WriteLine("Select a number you would like to divide by");
                int userNum = Convert.ToInt32(Console.ReadLine());

                //Loop that divides user number by each item in list

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = numbers[i] / userNum;

                    Console.WriteLine(numbers[i]);
                }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please type in a whole number");
                }

                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please don't divide by zero");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }

            }
        }
 }
