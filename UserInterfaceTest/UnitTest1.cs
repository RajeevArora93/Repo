using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverter;

namespace UserInterfaceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_UserInputString_ReturnsValueOfZero_WhenCalled()
        {
            //Arrange
            UserInterface userInterface = new UserInterface();
            
            //Act
            double exchangeRate = userInterface.UserInputString();

            //Assert
            Assert.AreEqual(0.0, exchangeRate);
        }
    }
}
