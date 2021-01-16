using System.Collections.Generic;

namespace disaster.entity
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public Disaster Disaster { get; set; }
        public List<Town> Towns { get; set; }

        
    }
}