using Infrastracture;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTestLibrary
{
    public class CalculationsTest
    {

        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {
            var calculation = new Calculation();

            //Arrange 
            double expected = 5;

            //Act
            double actual = calculation.Add(1, 4);

            //Asset
            Assert.Equal(actual, expected);

        }
    }
}
