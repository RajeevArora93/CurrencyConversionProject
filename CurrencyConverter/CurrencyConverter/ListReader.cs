using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class ListReader
    {
        List<Currency> listOfCurrencies;

        public ListReader()
        {
            listOfCurrencies = new List<Currency>();
        }

        public virtual List<Currency> ReadList() 
        {
            return listOfCurrencies;
        }
    }
}
