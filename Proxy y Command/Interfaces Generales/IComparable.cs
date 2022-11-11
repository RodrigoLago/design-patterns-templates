namespace ProxyCommand
{
    public interface IComparable
    {
        public bool SosIgual(IComparable elem);
        public bool SosMenor(IComparable elem);
        public bool SosMayor(IComparable elem);

    }
}
