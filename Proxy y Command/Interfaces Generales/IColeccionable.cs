namespace ProxyCommand
{
    public interface IColeccionable
    {
        public int Cuantos();
        public IComparable Minimo();
        public IComparable Maximo();
        public void Agregar(IComparable elem);
        public bool Contiene(IComparable elem);
    }
}
