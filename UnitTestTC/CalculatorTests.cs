using Xceed.Wpf.Toolkit;
using TestTC.Controllers;

namespace UnitTestTC
{
    public class CalculatorTests
    {
        [Fact]
        public void Calculator_ShouldReturnCorrectResult()
        {
            var result = HomeController.Calculator(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Calculator_ShouldReturnFailedTest()
        {
            var result = HomeController.Calculator(3, 3);
            Assert.Equal(5, result);
        }
    }
}
