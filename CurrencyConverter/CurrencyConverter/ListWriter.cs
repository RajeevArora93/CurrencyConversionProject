using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class ListWriter
    {
        List<Currency> ListOfCurrencies;

        public ListWriter()
        {
            ListOfCurrencies = new List<Currency>();
        }

        public virtual List<Currency> AddToList(Currency currency) 
        {
            ListOfCurrencies.Add(currency);
            return ListOfCurrencies;
        }
       
    }
}
