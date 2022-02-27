using System;

namespace lab2
{
    static class Program
    {
        static void Main(string[] args)
        {
            IPayload payload1 = new PayloadPassenger(100);
            IPayload payload2 = new PayloadPassenger(150);

            Plane plane1 = new CivilPlane(payload1, "name1");
            Plane plane2 = new CivilPlane(payload2, "name2");

            var planes = new[] {plane1, plane2};
            
            Angar<Plane> angar = new Angar<Plane>(planes);

            Airport airport = new Airport("Minsk", planes);
            Airport airport2 = new Airport("Madrid", new[] {angar.Planes[1]});
            Airport airport3 = new Airport("Rome", new[] {angar.Planes[1]});

            
            Console.WriteLine(airport.sendPlaneToFlight(0, airport2));
            Console.WriteLine(airport.sendPlaneToFlight(1, airport3));

        }
        
        public static string Convert(this string str, Airport a)
        {
            return $"Country: {Airport.COUNTRY} City: {a.City} Plane count: {a.Planes.Length}";
        }
    }
}