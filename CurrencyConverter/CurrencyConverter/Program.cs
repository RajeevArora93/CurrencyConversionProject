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
            ReadRates r = new ReadRates("C:/Users/rajeev.arora/Source/Repos/CurrencyConversionProject/CurrencyConverter/CurrencyRate.xml"); 

            r.GetRatesData();

            Console.ReadLine();
        }
    }
}
