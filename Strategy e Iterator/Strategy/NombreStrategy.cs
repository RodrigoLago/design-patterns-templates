namespace Strategy_e_Iterator
{
    public class NombreStrategy : IAlumnoStrategy
    {
        public bool SosIgual(IComparable comp1, IComparable comp2)
        {
            return ((Alumno)comp1).Nombre.CompareTo(((Alumno)comp2).Nombre) == 0;
        }

        public bool SosMayor(IComparable comp1, IComparable comp2)
        {
            return ((Alumno)comp1).Nombre.CompareTo(((Alumno)comp2).Nombre) > 0;
        }

        public bool SosMenor(IComparable comp1, IComparable comp2)
        {
            return ((Alumno)comp1).Nombre.CompareTo(((Alumno)comp2).Nombre) < 0;
        }
    }
}