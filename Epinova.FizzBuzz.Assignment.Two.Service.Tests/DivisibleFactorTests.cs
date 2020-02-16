using System;
using Epinova.FizzBuzz.Assignment.Two.Service.Type;
using Xunit;

namespace Epinova.FizzBuzz.Assignment.Two.Service.Tests
{
    public class DivisibleFactorTests
    {
        [Fact]
        public void DivisibleFactor_SetFactor_GivenZero_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new DivisibleFactor(0, ""));
        }

        [Fact]
        public void DivisibleFactor_SetWord_GivenEmptyString_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new DivisibleFactor(3, ""));
        }

        [Fact]
        public void DivisibleFactor_SetWord_GivenNull_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new DivisibleFactor(3, null));
        }
    }
}