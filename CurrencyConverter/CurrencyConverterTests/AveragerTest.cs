using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverter;
using System.Collections.Generic;

namespace UserInterfaceTest
{
    [TestClass]
    public class AveragerTest
    {
        
        [TestMethod]
        public void Test_Average_ReturnsAverageOfOneRate_WhenGivenACurrency()
        {
            //Arrange
            Currency currency = new Currency("15-05-01", "USD", "1.700");
            
            //Act   
            List<Currency> listOfCurrencies = new List<Currency>();
            listOfCurrencies.Add(currency);
            Averager averager = new Averager();
            double averageRate = averager.Average("USD", listOfCurrencies);

            //Assert
            Assert.AreEqual(1.7, averageRate);
             
        }

        [TestMethod]
        public void Test_Average_ReturnsAverageOfTwoRates_WhenListContainsTwoRatesOfTheSameCurrencies()
        {
            //Arrange
            Currency currency = new Currency("15-05-01", "USD", "1.700");
            Currency currency2 = new Currency("15-05-02", "USD", "1.500");

            //Act   
            List<Currency> listOfCurrencies = new List<Currency>() 
            {
                currency,
                currency2            
            };
            
            Averager averager = new Averager();
            double averageRate = averager.Average("USD", listOfCurrencies);

            //Assert
            Assert.AreEqual(1.60, averageRate);
        }

        [TestMethod]
        public void Test_Average_ReturnsAverageOfThreeRates_WhenListContainsThreeRatesOfTheSameCurrencies()
        {
              //Arrange
            Currency currency = new Currency("15-05-01", "USD", "1.700");
            Currency currency2 = new Currency("15-05-02", "USD", "1.500");
            Currency currency3 = new Currency("15-05-03", "USD", "1.750");
    

            //Act   
            List<Currency> listOfCurrencies = new List<Currency>() 
            {
                currency,
                currency2,
                currency3
            };
            
            Averager averager = new Averager();
            double averageRate = averager.Average("USD", listOfCurrencies);

            //Assert
            Assert.AreEqual(1.65, averageRate);
        }

        [TestMethod]
        public void Test_Average_ReturnsAverageOfThreeRatesOfTheGivenCurrency_WhenListContainsTwoDifferentCurrencies()
        {
            //Arrange
            Currency currency = new Currency("15-05-01", "USD", "1.700");
            Currency currency2 = new Currency("15-05-02", "USD", "1.500");
            Currency currency3 = new Currency("15-05-03", "USD", "1.750");
            Currency currency4 = new Currency("15-05-02", "JPY", "1.570");
            Currency currency5 = new Currency("15-05-03", "JPY", "1.759");


            //Act   
            List<Currency> listOfCurrencies = new List<Currency>() 
            {
                currency,
                currency2,
                currency3
            };            

            //Act
            Averager averager = new Averager();
            double averageRate = averager.Average("USD", listOfCurrencies);

            //Assert
            Assert.AreEqual(1.65, averageRate);
        }
    }
}