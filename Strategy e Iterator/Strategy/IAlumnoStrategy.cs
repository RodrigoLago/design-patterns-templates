using IComparable = Strategy_e_Iterator.Interfaces.IComparable;
namespace Strategy_e_Iterator.Strategy
{
    public interface IAlumnoStrategy
    {
        public bool SosIgual(IComparable comp1, IComparable comp2);
        public bool SosMenor(IComparable comp1, IComparable comp2);
        public bool SosMayor(IComparable comp1, IComparable comp2);

    }
}
