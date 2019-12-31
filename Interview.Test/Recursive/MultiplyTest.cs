using FluentAssertions;
using Interview.Recursive;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.Recursive
{
    public class MultiplyTest
    {
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(5, -5, -25)]
        public void Run_GivenTwoNumbers_ReturnMultiply(int firstNumber, int secondNumber, int expectedResult)
        {
            var multiply = new Multiply();

            var result = multiply.Run(firstNumber, secondNumber);

            result.Should().Be(expectedResult);

        }
    }
}
