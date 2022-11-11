namespace AdapterDecorator
{
    class PorLegajo : IEstrategiaAlumno
    {
        public bool SosIgual(IComparable a1, IComparable a2)
        {
            return ((IEstudiante)a1).GetLegajo() == (((IEstudiante)a2).GetLegajo());
        }

        public bool SosMayor(IComparable a1, IComparable a2)
        {
            return ((IEstudiante)a1).GetLegajo() > (((IEstudiante)a2).GetLegajo());
        }

        public bool SosMenor(IComparable a1, IComparable a2)
        {
            return ((IEstudiante)a1).GetLegajo() < (((IEstudiante)a2).GetLegajo());
        }
    }
}
