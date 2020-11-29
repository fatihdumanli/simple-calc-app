using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalcApp.Tests
{
    [TestClass]
    public class CalcUnitTests
    {
        private readonly ICalcService _calcService = new CalcService();


        [TestMethod]
        public void Should_Perform_Sum_Correctly()
        {

            var result = _calcService.Sum(5, 2);
            Assert.AreEqual(result, 7);
        }


        [TestMethod]
        public void Should_Perform_Subtract_Correctly()
        {

            var result = _calcService.Subtract(5, 2);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void Should_Perform_Multiply_Correctly()
        {

            var result = _calcService.Multiply(5, 2);
            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void Should_Perform_Divide_Correctly()
        {

            var result = _calcService.Divide(6, 2);
            Assert.AreEqual(result, 3);
        }
    }

} 