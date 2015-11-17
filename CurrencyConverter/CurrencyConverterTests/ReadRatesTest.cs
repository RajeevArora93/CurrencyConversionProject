using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverter;

namespace CurrencyConverterTests
{
    [TestClass]
    public class ReadRatesTest
    {
        [TestMethod]
        public void Test_ReadXmlFile_XmlFileHasBeenRead_WhenReadXmlFileIsCalled()
        {
            ReadRates reader = new ReadRates();

            reader.ReadXmlFile("C:/Users/rajeev.arora/Source/Repos/CurrencyConversionProject/CurrencyConverter/CurrencyRates.xml");

           // Assert.AreEqual( );
        }
    }
}
