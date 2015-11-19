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
    public class ReadXmlData
    {

        XmlDocument doc;
        ListWriter storeXmlData;

        public ReadXmlData(string filename) 
        {
            storeXmlData = new ListWriter();
            doc = new XmlDocument();
            doc.Load(filename);
        }

        public void GetRatesData()
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

                            storeXmlData.AddToList(new Currency(node2.Attributes[0].Value,node3.Attributes[0].Value, node3.Attributes[1].Value));
                        }
                    }
                }
            }
        }
    }
}
