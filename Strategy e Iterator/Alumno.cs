namespace StrategyIterator
{
    public class Alumno : Persona, IComparable
    {
        IAlumnoStrategy Strategy { get; set; }
        public Numero Legajo { get; set; }
        public Numero Promedio { get; set; }
        public Alumno(string nombre, Numero dni, Numero legajo, Numero promedio) : base(nombre, dni)
        {
            Legajo = legajo;
            Promedio = promedio;
            Strategy = new PromedioStrategy();
        }
        public void SetStrategy(IAlumnoStrategy strategy)
        {
            Strategy = strategy;
        }
        public new bool SosIgual(IComparable alumno)
        {
            return Strategy.SosIgual(this, alumno);
        }
        public new bool SosMenor(IComparable alumno)
        {
            return Strategy.SosMenor(this, alumno);
        }
        public new bool SosMayor(IComparable alumno)
        {
            return Strategy.SosMayor(this, alumno);
        }
    }
}
