namespace StrategyIterator
{
    public class LegajoStrategy : IAlumnoStrategy
    {
        public bool SosIgual(IComparable comp1, IComparable comp2)
        {
            return ((Alumno)comp1).Legajo.SosMayor(((Alumno)comp2).Legajo);
        }

        public bool SosMayor(IComparable comp1, IComparable comp2)
        {
            return ((Alumno)comp1).Legajo.SosMayor(((Alumno)comp2).Legajo);
        }

        public bool SosMenor(IComparable comp1, IComparable comp2)
        {
            return ((Alumno)comp1).Legajo.SosMenor(((Alumno)comp2).Legajo);
        }
    }
}
