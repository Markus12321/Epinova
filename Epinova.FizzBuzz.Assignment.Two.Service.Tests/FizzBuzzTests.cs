using System;
using System.Collections.Generic;
using Epinova.FizzBuzz.Assignment.Two.Service.CustomException;
using Epinova.FizzBuzz.Assignment.Two.Service.Tests.Data;
using Epinova.FizzBuzz.Assignment.Two.Service.Type;
using Xunit;

namespace Epinova.FizzBuzz.Assignment.Two.Service.Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzzService service;


        [Theory]
        [ClassData(typeof(ValidData))]
        public void FizzBuzzService_Process_GivenValidData_CompilesCorrectList(int sampleSize, bool ascending,
            List<DivisibleFactor> divisibleFactors, List<string> expected)
        {
            service = new FizzBuzzService(sampleSize, divisibleFactors, ascending);

            service.Process();

            var actual = service.ProcessedList;

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void FizzBuzzService_Process_GivenEmptyListOfDivisibleFactors_ThrowFizzBuzzException()
        {
            service = new FizzBuzzService(100, new List<DivisibleFactor>());

            Assert.Throws<FizzBuzzException>(() => service.Process());
        }


        [Fact]
        public void FizzBuzzService_SetCount_GivenZero_ThrowArgumentException()
        {
            service = new FizzBuzzService(100, new List<DivisibleFactor>
            {
                new DivisibleFactor(3, "Fizz")
            });

            Assert.Throws<ArgumentException>(() => service.Count = 0);
        }
    }
}