namespace disaster.entity
{
    public class Town
    {
        public int TownId { get; set; }
        public string TownName { get; set; }
        public Disaster Disaster { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public float Latitute { get; set; }
        public float Longtitute { get; set; }
    }
}