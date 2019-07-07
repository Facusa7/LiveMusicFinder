using System.Collections.Generic;

namespace LiveMusicFinder.Models
{
    public class Venue
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class VenueData
    {
        public List<Venue> Venue { get; set; }
    }
}
