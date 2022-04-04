using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClassPattern.Classes
{
    public static class TripAdvisorData
    {
        public static List<TripAdvisor> GetData() =>
        new List<TripAdvisor>
        {
            new TripAdvisor { Mail = "example1@gmail.com", Hotel = "Warsaw Hotel ", Opinion = "4 stars -> It was fine" },
            new TripAdvisor { Mail = "example2@gmail.com", Hotel = "Centrum Hotel ", Opinion = "5 stars -> Very good" },
            new TripAdvisor { Mail = "example3@gmail.com", Hotel = "Gdansk Hotel ", Opinion = "3 stars -> Not bad" },
            new TripAdvisor { Mail = "example4@gmail.com", Hotel = "Ochota Hotel ", Opinion = "4 stars -> Could be better" },
            new TripAdvisor { Mail = "example5@gmail.com", Hotel = "Krakow Hotel ", Opinion = "4 stars -> Not bad" }
        };
    }
}
