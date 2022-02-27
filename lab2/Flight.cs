using System.IO;

namespace lab2
{
    public class Flight
    {
        private Airport AirportTo;
        private Airport AirportFrom;
        private Plane Plane;

        public Flight(Airport airportTo, Airport airportFrom, Plane plane)
        {
            AirportTo = airportTo;
            AirportFrom = airportFrom;
            Plane = plane;
        }

        public void setAirportTo(Airport airport)
        {
            AirportTo = airport;
        }
        
        public void setAirportFrom(Airport airport)
        {
            AirportFrom = airport;
        }

        public override string ToString()
        {
            return $"From {AirportFrom.City} to {AirportTo.City}";
        }
    }
}