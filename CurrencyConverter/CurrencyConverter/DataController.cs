using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class DataController
    {
        protected ListWriter writer;
        protected ListReader reader;

        public DataController(ListWriter writer, ListReader reader)
        {
            this.writer = writer;
            this.reader = reader;
        }

        public List<Currency> GetAllCurrencyInfo() 
        {
            return reader.ReadList();
        }

        public void AddData(Currency currency) 
        {
            writer.AddToList(currency);
        }
    }
}
