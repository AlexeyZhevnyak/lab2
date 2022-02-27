namespace lab2
{
    public abstract class Plane
    {
        protected Plane(IPayload payload, string pilotName)
        {
            Payload = payload;
            PilotName = pilotName;
        }

        public IPayload Payload { get; set; }

        public string PilotName { get; set; }
    }
}