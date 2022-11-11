namespace interfaces
{
    public interface IColeccionable
    {
        public int Cuantos();
        public IComparable Minimo();
        public IComparable Maximo();
        public void Agregar(IComparable comparable);
        public bool Contiene(IComparable comparable);

    }
}
