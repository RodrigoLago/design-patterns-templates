namespace ProxyCommand
{
    class PorCalificacion : IEstrategiaAlumno
    {
        public bool SosIgual(IComparable a1, IComparable a2)
        {
            return ((IEstudiante)a1).GetCalificacion() == ((IEstudiante)a2).GetCalificacion();
        }

        public bool SosMayor(IComparable a1, IComparable a2)
        {
            return ((IEstudiante)a1).GetCalificacion() > ((IEstudiante)a2).GetCalificacion();
        }

        public bool SosMenor(IComparable a1, IComparable a2)
        {
            return ((IEstudiante)a1).GetCalificacion() < ((IEstudiante)a2).GetCalificacion();
        }
    }
}
