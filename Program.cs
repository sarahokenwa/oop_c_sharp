using System;

namespace oop_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OOP_Math math = new();
            double average = math.CalculateAverage(math.CollateNumbers(5));
            OOP_Message.DisplayMessage(4,average);
        }
    }
}
    
