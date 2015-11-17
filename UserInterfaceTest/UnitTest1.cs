using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverter;
using Moq;

namespace UserInterfaceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_UserInputString_ReturnsValueOfZero_WhenCalledPassedACurrency()
        {
            //Arrange
            string someInput = "SomeCurrency";
            CurrencyConverter.CurrencyConverter currencyConverter = new CurrencyConverter.CurrencyConverter();
            
            //Act
            double exchangeRate = currencyConverter.ConvertCurrency(someInput);

            //Assert
            Assert.AreEqual(0.0, exchangeRate);
        }

        //[TestMethod]
        //public void Test_AverageRate_ReturnAverageRateOfCurrency_WhenPassedACurrency()
        //{
        //    //Arrange
        //    Currencies comeCurrency = new Currencies();
        //    Averager averager = new Averager();
            
        //    //Act
        //    double average = averager.Average(comeCurrency);

        //    //Assert
        //    Assert.AreEqual(1, average);
        //}

        [TestMethod]
        public void Test_()
        {
            //Arrange
            Currencies currency = new Currencies();
            Averager averager = new Averager();
            Mock<DatabaseReader> mockDatabaseReader = new Mock<DatabaseReader>();


            //Act
            averager.Average(currency);

            //Assert
            mockDatabaseReader.Verify(r => r.ReadDatabase(It.IsAny<Currencies>()),Times.Once);
        }


    }
}
