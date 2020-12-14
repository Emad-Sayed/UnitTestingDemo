using Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture
{
    public class Calculation : ICalculation
    {
        public int Calculate1(string word)
        {
            switch (word)
            {
                case "One":
                    return 1;
                case "Two":
                    return 2;
                case "Three":
                    return 3;
                default:
                    return -1;
            }
        }
        public double Add(double first, double second) => first + second;
        public double Subtract(double first, double second) => first - second;
        public double Multiply(double first, double second) => first * second;
        public double Divide(double first, double second)
        {
            if (second == 0)
                throw new DivideByZeroException();
            return first / second;
        }
    }
}
