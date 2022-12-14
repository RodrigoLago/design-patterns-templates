namespace StrategyIterator
{
    public class PromedioStrategy : IAlumnoStrategy
    {
        public bool SosIgual(IComparable comp1, IComparable comp2)
        {
            return ((Alumno)comp1).Promedio.SosIgual(((Alumno)comp2).Promedio);
        }

        public bool SosMayor(IComparable comp1, IComparable comp2)
        {
            return ((Alumno)comp1).Promedio.SosMayor(((Alumno)comp2).Promedio);
        }

        public bool SosMenor(IComparable comp1, IComparable comp2)
        {
            return ((Alumno)comp1).Promedio.SosMenor(((Alumno)comp2).Promedio);
        }
    }
}
