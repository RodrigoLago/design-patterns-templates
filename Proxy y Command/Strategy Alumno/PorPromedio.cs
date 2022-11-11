namespace ProxyCommand
{
    public class PorPromedio : IEstrategiaAlumno
    {
        public bool SosIgual(IComparable a1, IComparable a2)
        {
            return ((IEstudiante)a1).GetPromedio() == (((IEstudiante)a2).GetPromedio());
        }

        public bool SosMayor(IComparable a1, IComparable a2)
        {
            return ((IEstudiante)a1).GetPromedio() > (((IEstudiante)a2).GetPromedio());
        }

        public bool SosMenor(IComparable a1, IComparable a2)
        {
            return ((IEstudiante)a1).GetPromedio() < (((IEstudiante)a2).GetPromedio());
        }
    }
}
