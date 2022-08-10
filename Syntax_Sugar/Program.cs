using System;

namespace Syntax_Sugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;

            string response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";

            Console.WriteLine(response);
        }
    }
}