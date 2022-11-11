namespace ProxyCommand
{
    public interface IEstrategiaAlumno
    {
        public bool SosIgual(IComparable a1, IComparable a2);
        public bool SosMenor(IComparable a1, IComparable a2);
        public bool SosMayor(IComparable a1, IComparable a2);
    }
}
