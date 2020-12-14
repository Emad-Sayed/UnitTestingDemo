using Infrastracture;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class CalculationTest
    {
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(4, 2, 6)]
        [InlineData(5, 5, 10)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            var calculations = new Calculation();
            //Arrange
            //double expected = 5;

            //Act
            double actual = calculations.Add(x, y);

            //Assert

            Assert.Equal(actual, expected);
        }
        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(8, 4, 2)]
        [InlineData(100, 2, 50)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            var calculations = new Calculation();
            //Arrange
            //double expected = 5;

            //Act
            double actual = calculations.Divide(x, y);

            //Assert

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Divide_ByZero()
        {
            var calculations = new Calculation();
            Assert.Throws<DivideByZeroException>(() => calculations.Divide(10, 0));
        }
    }
}
