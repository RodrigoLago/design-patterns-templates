namespace StrategyIterator
{
    public interface IAlumnoStrategy
    {
        public bool SosIgual(IComparable comp1, IComparable comp2);
        public bool SosMenor(IComparable comp1, IComparable comp2);
        public bool SosMayor(IComparable comp1, IComparable comp2);

    }
}
