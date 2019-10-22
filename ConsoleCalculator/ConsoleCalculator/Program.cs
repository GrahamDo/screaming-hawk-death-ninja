using System;

namespace ConsoleCalculator
{

    public static class Calculator
    {
        public static int Add(int val1, int val2)
        {
            return val1 * val2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"2 + 2 = {Calculator.Add(2, 2)}");
        }
    }
}
