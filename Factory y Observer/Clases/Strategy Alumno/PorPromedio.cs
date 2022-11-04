namespace FactoryObserver
{
    public class PorPromedio : IEstrategiaAlumno
    {
        public bool SosIgual(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).GetPromedio().SosIgual(((Alumno)a2).GetPromedio());
        }

        public bool SosMayor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).GetPromedio().SosMayor(((Alumno)a2).GetPromedio());
        }

        public bool SosMenor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).GetPromedio().SosMenor(((Alumno)a2).GetPromedio());
        }
    }
}
