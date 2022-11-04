namespace Strategy_e_Iterator
{
    public class DniStrategy : IAlumnoStrategy
    {
        public bool SosIgual(IComparable comp1, IComparable comp2)
        {
            return ((Alumno)comp1).Dni.SosIgual(((Alumno)comp2).Dni);
        }

        public bool SosMayor(IComparable comp1, IComparable comp2)
        {
            return ((Alumno)comp1).Dni.SosMayor(((Alumno)comp2).Dni);
        }

        public bool SosMenor(IComparable comp1, IComparable comp2)
        {
            return ((Alumno)comp1).Dni.SosMenor(((Alumno)comp2).Dni);
        }
    }
}
