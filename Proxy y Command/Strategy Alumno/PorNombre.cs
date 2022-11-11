namespace ProxyCommand
{
    class PorNombre : IEstrategiaAlumno
    {
        public bool SosIgual(IComparable a1, IComparable a2)
        {
            return (((IEstudiante)a1).GetNombre()).CompareTo(((IEstudiante)a2).GetNombre()) == 0;
        }

        public bool SosMayor(IComparable a1, IComparable a2)
        {
            return (((IEstudiante)a1).GetNombre()).CompareTo(((IEstudiante)a2).GetNombre()) == 1;
        }

        public bool SosMenor(IComparable a1, IComparable a2)
        {
            return (((IEstudiante)a1).GetNombre()).CompareTo(((IEstudiante)a2).GetNombre()) == -1;
        }
    }
}
