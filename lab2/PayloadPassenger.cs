using System;

namespace lab2
{
    public class PayloadPassenger : IPayload
    {
        private int _count;

        public PayloadPassenger(int count)
        {
            _count = count;
        }

        public int Count
        {
            get => _count;
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
                else _count = 0;
            }
        }

        public string getType()
        {
            return "Passengers";
        }
    }
}