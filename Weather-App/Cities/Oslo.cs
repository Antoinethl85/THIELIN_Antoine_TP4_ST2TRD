namespace Weather_App.Cities
{
    public class Oslo
    {
        private Coordinates _oslo = new Coordinates(59.9138688f, 10.7522454f);
        
        public Coordinates getCoordinates()
        {
            return this._oslo;
        }
    }
}