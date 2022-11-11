namespace ProxyCommand
{
    class PilaIterator : IIterator
    {
        private List<IComparable> pila = new List<IComparable>();
        int posicion = 0;
        public PilaIterator(List<IComparable> pila)
        {
            this.pila = pila;
        }
        public object Current()
        {
            return pila[posicion];
        }
        public bool HasNext()
        {
            return posicion < pila.Count;
        }
        public void Next()
        {
            posicion++;
        }
    }
}
