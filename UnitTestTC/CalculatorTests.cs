using Xceed.Wpf.Toolkit;
using TestTC.Controllers;

namespace UnitTestTC
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectResult()
        {
            var result = HomeController.Calculator(2, 3);
            Assert.Equal(5, result);
        }
    }
}
