using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClassPattern.Classes
{
    class XmlToJsonAdapter
    {
        private readonly XmlConverter _xmlConverter;

        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public void ConvertXmlToJson()
        {
            var tripadvisors = _xmlConverter.GetXML()
                    .Element("TripAdvisors")
                    .Elements("TripAdvisors")
                    .Select(t => new TripAdvisor
                    {
                        Mail = t.Attribute("Mail").Value,
                        Hotel = t.Attribute("Hotel").Value,
                        Opinion = t.Attribute("Opinion").Value
                    });

            new JsonConverter(tripadvisors)
                .ConvertToJson();
        }
    }
}
