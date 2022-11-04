namespace FactoryObserver
{
    class PorDni : IEstrategiaAlumno
    {
        public bool SosIgual(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).GetDni().SosIgual(((Alumno)a2).GetDni());
        }

        public bool SosMayor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).GetDni().SosMenor(((Alumno)a2).GetDni());
        }

        public bool SosMenor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).GetDni().SosMayor(((Alumno)a2).GetDni());
        }
    }
}
