using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_c_sharp
{
    internal class OOP_Message
    {
        const string inputPrompt = "Kindly input a number between 95 and 121"; // 0
        const string greatThan100Message = "Average is {0} and greater than 100"; // 1
        const string lessThan100Message = "Average is {0} and it is less than or equal to 100"; // 2
        const string numberErrorMessage = "Sorry {0} is not between 95 and 121"; // 3
        const string displayAverage = "The average of these numbers is {0}"; // 4

        public static void DisplayMessage(short messageIndex, double? number = null)
        {
            switch (messageIndex)
            {
                case 0:
                    Console.WriteLine(inputPrompt);
                    break;
                case 1:
                    Console.WriteLine(greatThan100Message);
                    break;
                case 2:
                    Console.WriteLine(lessThan100Message);
                    break;
                case 3:
                    Console.WriteLine(numberErrorMessage);
                    break;
                default:
                    Console.WriteLine(displayAverage);
                    break;

            }
        }
    }
}
