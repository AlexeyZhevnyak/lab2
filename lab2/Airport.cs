namespace lab2
{
    public class Airport
    {
        public static string COUNTRY = "Belarus";
        private string _city;
        private Plane[] _planes;

        public Airport(string city, Plane[] planes)
        {
            _city = city;
            _planes = planes;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public Plane[] Planes
        {
            get => _planes;
            set => _planes = value;
        }
        
        public Plane this[int index]
        {
            get => _planes[index];
            set => _planes[index] = value;
        }

        public Flight sendPlaneToFlight(int i, Airport airportTo)
        {
            return new Flight(airportTo, this, _planes[i]);
        }

        public static bool operator <(Airport a1, Airport a2)
        {
            return a1._planes.Length < a2._planes.Length;
        }
        
        public static bool operator >(Airport a1, Airport a2)
        {
            return a1._planes.Length > a2._planes.Length;
        }
        
    }
}