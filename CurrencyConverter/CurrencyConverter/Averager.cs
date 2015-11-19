using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class Averager
    {        
        public double Average(string currency, List<Currency> listOfCurrencies)
        {           
            double sumOfCurrencies = 0;
            var numberOfRates = 0;          

            foreach(Currency curr in listOfCurrencies)
            {               
                if (curr.currency == currency)
                {                  
                    numberOfRates++;

                    sumOfCurrencies += double.Parse(curr.rate);                   
                }
            }                     

            double average  = sumOfCurrencies / numberOfRates;

            return Math.Round(average, 2);
        }       
    }
}