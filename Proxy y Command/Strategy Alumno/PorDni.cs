namespace ProxyCommand
{
    class PorDni : IEstrategiaAlumno
    {
        public bool SosIgual(IComparable a1, IComparable a2)
        {
            return ((IEstudiante)a1).GetDni() == (((IEstudiante)a2).GetDni());
        }

        public bool SosMayor(IComparable a1, IComparable a2)
        {
            return ((IEstudiante)a1).GetDni() > (((IEstudiante)a2).GetDni());
        }

        public bool SosMenor(IComparable a1, IComparable a2)
        {
            return ((IEstudiante)a1).GetDni() < (((IEstudiante)a2).GetDni());
        }
    }
}
