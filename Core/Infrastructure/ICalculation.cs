using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure
{
    public interface ICalculation
    {
        public int Calculate1(string word);
        public double Add(double first, double second);
        public double Subtract(double first, double second);
        public double Divide(double first, double second);
        public double Multiply(double first, double second);
    }
}
