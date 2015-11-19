using System;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverter;
using System.Collections.Generic;

namespace CurrencyConverterTests
{
    [TestClass]
    public class DataControllerTest
    {
        private DataController dataController;
        private Mock<Currency> mockCurrency;
        private Mock<ListWriter> mockWriter;
        private Mock<ListReader> mockReader;
        private Mock<List<Currency>> mockList;

        [TestInitialize]
        public void setup()
        {
            mockList = new Mock<List<Currency>>();

            mockCurrency = new Mock<Currency>(null, null, null);

            mockWriter = new Mock<ListWriter>();

            mockReader = new Mock<ListReader>();
            mockReader.Setup(x => x.ReadList()).Returns(mockList.Object);

            dataController = new DataController(mockWriter.Object, mockReader.Object);
        }

        [TestMethod]
        public void Test_GetAllCurrencyInfo_CallsReadListMethodOfInjectedReaderObject_WhenCalled()
        {
            dataController.GetAllCurrencyInfo();
            mockReader.Verify(r => r.ReadList(), Times.Once);
        }

        [TestMethod]
        public void test_GetAllCurrencyInfo_ReturnsListGivenToItByReadListMethodOfInjectedReader_WhenCalled()
        {
            List<Currency> listOfCurrencies = dataController.GetAllCurrencyInfo();
            CollectionAssert.AreEqual(mockList.Object, listOfCurrencies);
        }

        [TestMethod]
        public void test_GetAllCurrencyInfo_ReturnsAnEmptyList_IfNoXmlDataAdded()
        {
            List<Currency> listOfCurrencies = dataController.GetAllCurrencyInfo();
            Assert.AreEqual(0, listOfCurrencies.Count);
        }

        [TestMethod]
        public void test_GetAllCurrencyInfo_ReturnsListOfSizeOne_IfOneCurrencyIsAdded()
        {
            mockList.Object.Add(new Currency("2015-10-04", "USD", "1.780"));
            List<Currency> listOfCurrencies = dataController.GetAllCurrencyInfo();
            Assert.AreEqual(1, listOfCurrencies.Count);
        }

        [TestMethod]
        public void test_AddData_CallsAddToList_WhenCalled()
        {
            dataController.AddData(mockCurrency.Object);
            mockWriter.Verify(a => a.AddToList(It.IsAny<Currency>()), Times.Once());
        }

        [TestMethod]
        public void test_AddData_CallsAddToListOfListWriterPassingCurrencyObjectDefinedAsInput_WhenCalled()
        {
            dataController.AddData(mockCurrency.Object);
            mockWriter.Verify(a => a.AddToList(mockCurrency.Object), Times.Once());
        }
    }
}
