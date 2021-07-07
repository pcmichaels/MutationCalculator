using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public static class Calculator
    {
        public static decimal Add(decimal x, decimal y) =>
            x + y;

        public static decimal Subtract(decimal x, decimal y) =>
            x - y;

        public static decimal Multiply(decimal x, decimal y) =>
            x * y;

        public static decimal Divide(decimal x, decimal y) =>
            x / y;

    }
}
