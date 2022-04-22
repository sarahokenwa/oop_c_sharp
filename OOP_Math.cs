using System;
namespace oop_c_sharp
{
    internal class OOP_Math
    {
        public double[] CollateNumbers(int numberCount)
        {
            double[] numberArray = new double[numberCount];
            for (int count = 1;  count <= numberCount; count++) // Looped 5times
            {
                Label11:
                // Prompt the user to input a number between 95 and 121
                OOP_Message.DisplayMessage(0);
                try
                {
                    double number = 0;
                    var input = Console.ReadLine(); //Accept the input
                    number = Convert.ToDouble(input == "" ? "0" : input); // Assign the input to the number variable
                    if (number >= 95 && number <= 121) // Check if the input is within the specified range
                    {
                        //Collate number here
                        numberArray[count - 1] = number;
                    }
                    else // if the number is not within the range, it should prompt the user that the number is not within the range
                    {
                        OOP_Message.DisplayMessage(3, number); // print a message to the user
                        goto Label11;

                    }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message.ToString() + ". This error was from " + exception.StackTrace.ToString());
                    goto Label11;
                }
            }
            return numberArray;
        }
        
        private double CalculateSum(double[] numbers)
        {
            double sum = 0;
            foreach(double number in numbers)
            {
                sum += number;
            }
            return sum;
           }
        public double CalculateAverage(double[] numbers)
        {
            double sum = CalculateSum(numbers);
            return sum / numbers.Length;
        }
    }
}
