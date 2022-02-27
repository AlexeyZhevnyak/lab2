namespace lab2
{
    public class Angar<T> where T : Plane
    {
        private T[] _t;

        public Angar(T[] t)
        {
            this._t = t;
        }

        public T[] Planes
        {
            get => _t;
            set => _t = value;
        }
    }
}