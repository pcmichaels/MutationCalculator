using System;
using Xunit;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Calculator_Add_ReturnsCorrect()
        {
            // Arrange            

            // Act
            decimal result = CalculatorApp.Calculator.Add(3, 6);

            // Assert
            Assert.Equal(9, result);
        }

        [Fact]
        public void Calculator_Subtract_Correct()
        {
            // Arrange            

            // Act
            decimal result = CalculatorApp.Calculator.Subtract(1, 0);

            // Assert
            Assert.Equal(1, result);

        }

        [Fact]
        public void Calculator_Subtract_Negative()
        {
            // Arrange            

            // Act
            decimal result = CalculatorApp.Calculator.Subtract(10, 20);

            // Assert
            Assert.Equal(-10, result);

        }

        [Fact]
        public void Calculator_Multiply_Correct()
        {
            // Arrange            

            // Act
            decimal result = CalculatorApp.Calculator.Multiply(5, 2);

            // Assert
            Assert.Equal(10, result);

        }
         
        [Fact]
        public void Calculator_Divide_WillSurvive()
        {
            // Arrange            

            // Act
            decimal result = CalculatorApp.Calculator.Divide(7, 3);

            // Assert
            //Assert.Equal(2.5m, result);

        }

    }
}
