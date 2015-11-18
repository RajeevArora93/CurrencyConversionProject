using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace CurrencyConverter
{
    public class ReadRates
    {

        Dictionary<Tuple<int, string>, Tuple<string, string>> currencies;
        XmlDocument doc;

        public ReadRates(string filename)
        {
            currencies = new Dictionary<Tuple<int,string>, Tuple<string, string>>();      
       
            doc = new XmlDocument();
            doc.Load(filename);
        }
        
        public Dictionary<Tuple<int, string>, Tuple<string, string>> GetRatesData() 
        {
            int count = 0;
            
            XmlNodeList nodeList = doc.DocumentElement.ChildNodes;

            foreach (XmlNode node in nodeList)
            {
                if (node.Name == "Cube")
                {
                    foreach (XmlNode node2 in node.ChildNodes)
                    {

                        foreach (XmlNode node3 in node2.ChildNodes)
                        {
                            count++;
                            var tuple = new Tuple<string, string>(node3.Attributes[0].Value, node3.Attributes[1].Value);
                            var tuple2 = new Tuple<int, string>(count, node2.Attributes[0].Value);
                            currencies.Add(tuple2, tuple);
                        }
                    }
                }
            }
            return currencies;  
             
            //foreach(KeyValuePair<Tuple<int, string>, Tuple<string, string>> entry in currencies)
            //{
            //    Console.WriteLine(entry.Key.Item1 + " " + entry.Key.Item2 + " " + entry.Value.Item1 + " " + entry.Value.Item2);
            //}
   
        }        
    }
}
