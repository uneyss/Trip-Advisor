using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdapterClassPattern.Classes
{
    class XmlConverter
    {
        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("TripAdvisors");
            var xAttributes = TripAdvisorData.GetData()
                .Select(t => new XElement("TripAdvisors",
                                    new XAttribute("Mail", t.Mail),
                                    new XAttribute("Hotel", t.Hotel),
                                    new XAttribute("Opinion", t.Opinion)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }
}