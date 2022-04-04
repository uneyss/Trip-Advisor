using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterClassPattern.Classes
{
    class JsonConverter
    {
        private IEnumerable<TripAdvisor> _tripadvisors;

        public JsonConverter(IEnumerable<TripAdvisor> tripadvisors)
        {
            _tripadvisors = tripadvisors;
        }

        public void ConvertToJson()
        {
            var jsonTripadvisors = JsonConvert.SerializeObject(_tripadvisors, Newtonsoft.Json.Formatting.Indented);

            Console.WriteLine("\nPrinting JSON list\n");
            Console.WriteLine(jsonTripadvisors);
        }
    }
}
