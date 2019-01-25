using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;             
            Arrays.ArrayUnidimensional();

            Console.ForegroundColor = ConsoleColor.Green;             
            Console.WriteLine();
            Arrays.ArrayMultiDimensional();

            Console.ResetColor();
        }
    }
}
