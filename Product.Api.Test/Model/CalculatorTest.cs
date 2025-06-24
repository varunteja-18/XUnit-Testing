using Product.Api.Model;
namespace Product.Api.Test
{
    public class CalculatorTest
    {
        [Fact] //annotation as test method
        public void Add_ReturnSum()
        {
            //Arrange - initilazation
            int a = 5;
            int b = 5;

            //Action - object creation
            var result = new Calculator();
            int sumresult = result.Add(a, b);

            //Assert - Testing condition
            Assert.Equal(10, sumresult);
        }

        [Fact] //annotation as test method
        public void Sub_ReturnSub()
        {
            //Arrange - initilazation
            int a = 5;
            int b = 5;

            //Action - object creation
            var result = new Calculator();
            int subresult = result.Sub(a, b);

            //Assert - Testing condition
            Assert.Equal(0, subresult);
        }

        [Fact] //annotation as test method
        public void Mul_ReturnMul()
        {
            //Arrange - initilazation
            int a = 5;
            int b = 5;

            //Action - object creation
            var result = new Calculator();
            int mulresult = result.Mul(a, b);

            //Assert - Testing condition
            Assert.Equal(25, mulresult);
        }

        [Fact]
        public void Div_ReturnsCorrectQuotient_WhenDivisorIsNotZero()
        {
            var calc = new Calculator();
            Assert.Equal(2, calc.Div(6, 3));
        }

        [Fact]
        public void Div_ThrowsException_WhenDividingByZero()
        {
            var calc = new Calculator();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calc.Div(5, 0));
        }
    }
}
