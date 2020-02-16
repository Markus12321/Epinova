using Epinova.FizzBuzz.Assignment.Two.Service.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;


namespace Epinova.FizzBuzz.Assignment.Two.Service.Tests.Data
{
    public class ValidData : TheoryData<int, bool, List<DivisibleFactor>, List<string>>
    {
        public ValidData()
        {
            Add(15, true, new List<DivisibleFactor>
            {
                new DivisibleFactor(3, "Fizz"),
                new DivisibleFactor(5, "Buzz")
            }, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz".Split(" ").ToList());

            Add(15, false, new List<DivisibleFactor>
            {
                new DivisibleFactor(3, "Fizz"),
                new DivisibleFactor(5, "Buzz")
            }, "BuzzFizz 14 13 Fizz 11 Buzz Fizz 8 7 Fizz Buzz 4 Fizz 2 1".Split(" ").ToList());

            Add(5, true, new List<DivisibleFactor>
            {
                new DivisibleFactor(1, "A"),
                new DivisibleFactor(2, "B"),
                new DivisibleFactor(3, "C"),
                new DivisibleFactor(4, "D"),
                new DivisibleFactor(5, "E")
            }, "A AB AC ABD AE".Split(" ").ToList());

            Add(10, true, new List<DivisibleFactor>
            {
                new DivisibleFactor(1, "A")
            }, "A A A A A A A A A A".Split(" ").ToList());

            Add(10, true, new List<DivisibleFactor>
            {
                new DivisibleFactor(1, "A")
            }, "A A A A A A A A A A".Split(" ").ToList());
        }
    }
}
