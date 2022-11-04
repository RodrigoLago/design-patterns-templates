namespace FactoryObserver
{
    class PorLegajo : IEstrategiaAlumno
    {
        public bool SosIgual(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).GetLegajo().SosIgual(((Alumno)a2).GetLegajo());
        }

        public bool SosMayor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).GetLegajo().SosMayor(((Alumno)a2).GetLegajo());
        }

        public bool SosMenor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).GetLegajo().SosMenor(((Alumno)a2).GetLegajo());
        }
    }
}
