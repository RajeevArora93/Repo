using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserInterfaceTest
{

    /// Tests CurrencyConverterTest

    [TestClass]
    public class CurrencyConverterTest
    {
        [TestMethod]
        public void Test_ConvertCurrencyByValue_ReturnsValueExchangeRate_WhenPassedValueToConvert()
        {
            //Arrange
            CurrencyConverter.CurrencyConverter converter = new CurrencyConverter.CurrencyConverter();
            CurrencyConverter.XmlRatesReader reader = new CurrencyConverter.XmlRatesReader(@"H:\Downloads\Repo-master\Repo-master\CurrencyConverter\ExchangeRates.xml");
            string date = "2015-11-18";
            Dictionary<Tuple<int, string>, Tuple<string, string>> dictionary = reader.GetRatesData();

            //Act
            double xRate = converter.ConvertCurrencyByValue(dictionary, "GBP", date, 1);

            //Assert
            Assert.AreEqual(0.700, xRate);
        }

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    //
        //    // TODO: Add test logic here
        //    //
        //}
    }
}
