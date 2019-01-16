using cart.api;
using System;
using Xunit;

namespace cart.test
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(4,200,200)]
        [InlineData(3, 200, 0)]
        [InlineData(9, 100, 200)]
        public void CheckDiscountAmountTest(int amount,double price,int expected)
        {
            var sut = new Calculator();
            var actual = sut.CheckDiscount(amount, price);
            Assert.Equal(expected, actual);
        }
    }
}
