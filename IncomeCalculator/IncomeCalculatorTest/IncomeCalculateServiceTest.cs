using System;
using IncomeCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IncomeCalculatorTest
{
    [TestClass]
    public class IncomeCalculateServiceTest
    {
        [TestMethod]
        public void IncomeAfterFederalTax_WithFirstLevel()
        {
            // arrange
            int _firstIncome = 5000;

            decimal _expectedIncome = 5000 - (5000 * 10 / 100);

            IncomeCalculateService _service = new IncomeCalculateService();

            // act
            double _result = _service.IncomeAfterFederalTax(_firstIncome);

            // assert
            Assert.IsNotNull(_result);
            Assert.AreEqual(_result, _expectedIncome);
        }

        [TestMethod]
        public void IncomeAfterFederalTax_WithSecondLevel()
        {
            // arrange
            int _firstIncome = 10000;

            double _expectedIncome = 10000 - (
                    952.50 + ((10000 - 9525) * IncomeRange.SecondIncome / 100)
                    );

            IncomeCalculateService _service = new IncomeCalculateService();

            // act
            double _result = _service.IncomeAfterFederalTax(_firstIncome);

            // assert
            Assert.IsNotNull(_result);
            Assert.AreEqual(_result, _expectedIncome);
        }
    }
}
