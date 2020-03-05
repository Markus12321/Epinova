using System;
using System.Collections.Generic;
using Epinova.FizzBuzz.Assignment.Two.Service;
using Epinova.FizzBuzz.Assignment.Two.Service.Type;

namespace Epinova.FizzBuzz.Assignment.Two.Client
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var factors = new List<DivisibleFactor>
            {
                new DivisibleFactor(3, "Fizz"),
                new DivisibleFactor(5, "Buzz")
            };

            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintList(100, factors);

            Console.WriteLine();

            factors = new List<DivisibleFactor>
            {
                new DivisibleFactor(9, "Jazz"),
                new DivisibleFactor(4, "Fuzz")
            };

            Console.ForegroundColor = ConsoleColor.Green;
            PrintList(100, factors, ascending: false);
        }

        private static void PrintList(int count, List<DivisibleFactor> divisibleFactors, bool ascending = true)
        {
            var service = new FizzBuzzService(100, divisibleFactors, ascending);

            service.Process();
            service.Print();
        }
    }
}