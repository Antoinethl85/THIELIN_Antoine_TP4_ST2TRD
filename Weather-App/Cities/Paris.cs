namespace Weather_App.Cities
{
    public class Paris
    {
        private Coordinates _paris = new Coordinates(48.856614f, 2.3522219f);
        
        public Coordinates getCoordinates()
        {
            return this._paris;
        }
    }
}