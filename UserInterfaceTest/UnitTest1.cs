using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverter;
using Moq;
using System.Collections.Generic;

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

        [TestMethod]
        public void Test_Average_ReturnsAverageOfOneRate_WhenDictionaryContontainsOneCurrency()
        {
            //Arrange
            Currencies currency = new Currencies();
            Averager averager = new Averager();
            DatabaseReader reader = new DatabaseReader();
            List<double> listForFirstCurrency = new List<double>();
            List<double> listForSecondCurrency = new List<double>();
            listForFirstCurrency.Add(1.2);
            listForSecondCurrency.Add(1.4);


            //Act
            Dictionary<string, List<double>> dictionary = reader.dictionaryOfCurrencies();
            dictionary.Add("1", listForFirstCurrency);
            dictionary.Add("2", listForSecondCurrency);

            double averageRate = averager.Average("1", dictionary);

            //Assert
            Assert.AreEqual(1.2, averageRate);
             
        }

        [TestMethod]
        public void Test_Average_ReturnsAverageOfTwoRates_WhenDictionaryContainsTwoRatesFroThatCurrency()
        {
            //Arrange
            Currencies currency = new Currencies();
            Averager averager = new Averager();
            DatabaseReader reader = new DatabaseReader();
            List<double> listForFirstCurrency = new List<double>();
            List<double> listForSecondCurrency = new List<double>();
            listForFirstCurrency.Add(1.2);
            listForFirstCurrency.Add(1.4);
            listForSecondCurrency.Add(1.4);

            //Act
            Dictionary<string, List<double>> dictionary = reader.dictionaryOfCurrencies();
            dictionary.Add("1", listForFirstCurrency);
            dictionary.Add("2", listForSecondCurrency);

            double averageRate = averager.Average("1", dictionary);

            //Assert
            Assert.AreEqual(1.3, averageRate);
        }

        [TestMethod]
        public void Test_Average_ReturnsAverageOfThreeRates_WhenDictionaryContainsThreeRatesForThatCurrency()
        {
            //Arrange
            Currencies currency = new Currencies();
            Averager averager = new Averager();
            DatabaseReader reader = new DatabaseReader();
            List<double> listForFirstCurrency = new List<double>();
            List<double> listForSecondCurrency = new List<double>();
            List<double> listForThridCurrency = new List<double>();
            listForFirstCurrency.Add(1.2);
            listForFirstCurrency.Add(1.4);
            listForSecondCurrency.Add(1.4);
            listForThridCurrency.Add(1.5);
            listForThridCurrency.Add(1.8);
            listForThridCurrency.Add(2.1);

            //Act
            Dictionary<string, List<double>> dictionary = reader.dictionaryOfCurrencies();
            dictionary.Add("1", listForFirstCurrency);
            dictionary.Add("2", listForSecondCurrency);
            dictionary.Add("3", listForThridCurrency);
            
            double averageRate = averager.Average("3", dictionary);

            //Assert
            Assert.AreEqual(1.8, averageRate);
        }

        [TestMethod]
        public void Test_Average_ReturnsAverageOfTwoRates_WhenDictionaryContainsThreeCurrencies()
        {
            //Arrange
            Currencies currency = new Currencies();
            Averager averager = new Averager();
            DatabaseReader reader = new DatabaseReader();
            List<double> listForFirstCurrency = new List<double>();
            List<double> listForSecondCurrency = new List<double>();
            List<double> listForThridCurrency = new List<double>();
            listForFirstCurrency.Add(1.2);
            listForFirstCurrency.Add(1.4);
            listForSecondCurrency.Add(1.4);
            listForSecondCurrency.Add(1.5);
            listForThridCurrency.Add(1.9);
            listForThridCurrency.Add(2.1);

            //Act
            Dictionary<string, List<double>> dictionary = reader.dictionaryOfCurrencies();
            dictionary.Add("1", listForFirstCurrency);
            dictionary.Add("2", listForSecondCurrency);
            dictionary.Add("3", listForThridCurrency);

            double averageRate = averager.Average("3", dictionary);

            //Assert
            Assert.AreEqual(2.0, averageRate);
        }

        //[TestMethod]
        //public void Test_()
        //{
        //    //Arrange
        //    Currencies currency = new Currencies();
        //    Averager averager = new Averager();
        //    Mock<DatabaseReader> mockDatabaseReader = new Mock<DatabaseReader>();
        //    Dictionary<string, string> dictionaryOfCurrencies = new  Dictionary<string, string>();

        //    //Act
        //    averager.Average(currency, dictionaryOfCurrencies);

        //    //Assert
        //    mockDatabaseReader.Verify(r => r.ReadDatabase(It.IsAny<Currencies>()),Times.Once);
        //}


    }
}
