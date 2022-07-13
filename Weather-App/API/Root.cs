namespace Weather_App.API
{
    public class Root
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public string timezone { get; set; }
        public int timezone_offset { get; set; }
        public Datum current { get; set; }
        public List list { get; set; }
    }
}