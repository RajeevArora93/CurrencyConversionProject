using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadXmlData r = new ReadXmlData("C:/Users/rajeev.arora/Source/Repos/CurrencyConversionProject/CurrencyConverter/CurrencyRates.xml");

            Dictionary<Tuple<int, string>, Tuple<string, string>> currAndRates = new Dictionary<Tuple<int, string>, Tuple<string, string>>();

            r.GetRatesData();

            Console.ReadLine();
        }
    }
}
