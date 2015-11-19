using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class Currency
    {
        private string _date;
        public string date
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _currency;       
        public string currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        private string _rate;
        public string rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
        

        public Currency(string date, string currency, string rate)
        {
            this.date = date;
            this.currency = currency;
            this.rate = rate;
        }
    }
}
