namespace Strategy_e_Iterator.Interfaces
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
