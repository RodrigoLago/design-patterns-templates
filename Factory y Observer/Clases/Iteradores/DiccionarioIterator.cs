namespace FactoryObserver
{
    class DiccionarioIterator : IIterator
    {
        Conjunto conjunto;
        int posicion = 0;
        public DiccionarioIterator(Conjunto conjunto)
        {
            this.conjunto = conjunto;
        }
        public object Current()
        {
            return conjunto.GetLista()[posicion];
        }

        public bool HasNext()
        {
            return posicion < conjunto.Cuantos();
        }

        public void Next()
        {
            posicion++;
        }
    }
}
