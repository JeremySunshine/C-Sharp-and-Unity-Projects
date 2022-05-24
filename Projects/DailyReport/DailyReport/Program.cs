using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy!");
            Console.ReadLine();

            Console.WriteLine("Student Daily Report");
            Console.ReadLine();


            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();


            Console.WriteLine("Hello: " + yourName + " What course are you on?");
            string CourseName = Console.ReadLine();


            Console.WriteLine("What Page on " + CourseName);
            string pageNum = Console.ReadLine();
            int pageNumInt = Convert.ToInt32(pageNum);


            Console.WriteLine("Do you need help with anything. Please answer true or false");
            string needHelp = Console.ReadLine();
            bool needHelp1 = Convert.ToBoolean(needHelp);



            Console.WriteLine("Where there any positive experiences you would like to share? Please give specifics.");
            string posEx = Console.ReadLine();



            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
           

            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            int hoursStudy1 = Convert.ToInt32(hoursStudy);
            

            Console.WriteLine("Thank your for your answers. An instructor will espond to this shortly, have a great day!");
            Console.ReadLine();

        }
    }
}
