namespace Weather_App.Cities
{
    public class New_York
    {
        private Coordinates _newYork = new Coordinates(40.712784f, -74.005941f);
        
        public Coordinates getCoordinates()
        {
            return this._newYork;
        }
    }
}