using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Requirement 2: Store two variables

            Console.Write("Please enter your full name person:  ");
            string fullName = Console.ReadLine();

            Console.Write("Please enter your location ");
            string location = Console.ReadLine();


            //Requirement 3: Output two WriteLine Statements to display variables
            //using intperpolation

            Console.WriteLine($"My name is {fullName} ");
            Console.WriteLine($"I am from: {location}");


            // Requirement 4: Output the current Date:

            string currentDate = DateTime.Now.ToString("MM.dd.yyy"); //store variable 
            Console.WriteLine($"Hello, {fullName}. The current date is {currentDate}.");

            //Requirement 5:Output the number of days until Christmas this year

            //Get Christmas 
            DateTime today = DateTime.Now;
            DateTime christmas = new DateTime(today.Month == 12 && today.Day > 25 ? today.Year + 1 : today.Year, 12, 25);
            //Get the time lapse from today until christmas
            TimeSpan timeSpanToChristmas = christmas - today;
            //Output onto screen
            Console.WriteLine($"Good News, Chirstmas is {timeSpanToChristmas.Days} days away!");

            //Requirement 6: Add the program example from section 2.1
            //in the C# Programming Yellow Book by Rob Miles.
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Please enter a width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter a height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
                   woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                   glassArea + " square metres");

            //Requirement 7: Cause the program to pause in the console so
            //that the application does not automatically terminate when 
            //launched from the Visual Studio run debugger tool. 

            Console.ReadLine();

        }
    }
}
