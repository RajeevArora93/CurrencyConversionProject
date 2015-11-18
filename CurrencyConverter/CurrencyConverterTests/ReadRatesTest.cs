using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverter;
using System.Collections.Generic;

namespace CurrencyConverterTests
{
    [TestClass]
    public class ReadRatesTest
    {
       
        [TestMethod]
        public void Text_GetRatesData_ItemsHaveBeenAddedToTheDictionary_WhenXmlDataHasBeenAdded()
        {
            string path = "C:/Users/rajeev.arora/Source/Repos/CurrencyConversionProject/CurrencyConverter/CurrencyRates.xml";
            ReadRates reader = new ReadRates(path);

            Dictionary<Tuple<int, string>, Tuple<string, string>> currencies = reader.GetRatesData();

            Assert.AreNotEqual(0, currencies.Count);
        }
    }
}
