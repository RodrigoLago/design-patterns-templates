namespace Interfaces
{
    public interface IComparable
    {
        public bool SosIgual(IComparable comparable);
        public bool SosMenor(IComparable comparable);
        public bool SosMayor(IComparable comparable);
    }
}
