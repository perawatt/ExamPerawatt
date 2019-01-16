using accumulatedinterest.api;
using System;
using Xunit;

namespace accumulatedinterest.test
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(10000,12,1200)]
        [InlineData(1000, 12, 120)]
        public void AccumulatedInterestTest(double balance, double percent, double expected)
        {
            var sut = new Calculator();
            var actual = sut.CheckSumInterest(balance, percent);
            Assert.Equal(expected, actual);
        }
    }
}
