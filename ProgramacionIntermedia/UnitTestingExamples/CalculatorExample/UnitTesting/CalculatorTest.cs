using CalculatorExample;
using Xunit;

namespace UnitTesting
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_TwoFloatNumbers_ReturnsCorrectResult()
        {
            //Arrange
            float n1 = 3;
            float n2 = 4;
            float expectedRes = 7;

            //Act
            float res = Calculator.Add(n1, n2);

            //Assert
            Assert.Equal(expectedRes, res);
        }

        [Fact]
        public void Substract_TwoFloatNumbers_ReturnsCorrectResult()
        {
            //Arrange
            float n1 = 3;
            float n2 = 4;
            float expectedRes = -1;

            //Act
            float res = Calculator.Sub(n1, n2);

            //Assert
            Assert.Equal(expectedRes, res);
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            //Arrange
            decimal n1 = 3;
            decimal n2 = 0;
            
            Assert.Throws<System.DivideByZeroException>(() => {

                //Act
                decimal res = Calculator.Div(n1, n2);

                //Assert
                Assert.IsType<decimal>(res);

            });

            
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(20.3, -6.2, -125.85999)]
        [InlineData(220, 0, 0)]
        public void Multiply_TwoFloatNumbers_ReturnsCorrectResult(float n1, float n2, float expectedRes)
        {
            //Arrange
            float res = 0;

            //Act
            res = Calculator.Mul(n1, n2);

            //Assert
            Assert.Equal(expectedRes, res);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(20, -8, -2.5)]
        [InlineData(220, 0.5, 440)]
        public void Divide_TwoDecimalNumbers_ReturnsCorrectResult(decimal n1, decimal n2, decimal expectedRes)
        {
            //Arrange
            decimal res = 0;

            //Act
            res = Calculator.Div(n1, n2);

            //Assert
            Assert.Equal(expectedRes, res);
        }
    }
}