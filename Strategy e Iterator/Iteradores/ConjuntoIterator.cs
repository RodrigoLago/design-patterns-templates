namespace Strategy_e_Iterator
{
    class ConjuntoIterator : IIterator
    {
        private List<IComparable> lista = new List<IComparable>();
        int posicion = 0;
        public ConjuntoIterator(List<IComparable> lista)
        {
            this.lista = lista;
        }
        public object Current()
        {
            return lista[posicion];
        }

        public bool HasNext()
        {
            return posicion < lista.Count;
        }

        public void Next()
        {
            posicion++;
        }
    }
}
