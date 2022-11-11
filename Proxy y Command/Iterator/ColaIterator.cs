namespace ProxyCommand
{
    class ColaIterator : IIterator
    {
        List<IComparable> cola = new List<IComparable>();
        private int posicion = 0;
        public ColaIterator(List<IComparable> cola)
        {
            this.cola = cola;
        }
        public object Current()
        {
            return cola[posicion];
        }
        public bool HasNext()
        {
            return posicion < cola.Count;
        }
        public void Next()
        {
            posicion++;
        }
    }
}
