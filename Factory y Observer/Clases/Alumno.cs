namespace FactoryObserver
{
    public class Alumno : Persona, IComparable
    {

        private Numero legajo;
        private Numero promedio;
        IEstrategiaAlumno estrategia;
        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        {

            this.legajo = new Numero(legajo);
            this.promedio = new Numero(promedio);
            estrategia = new PorDni();
        }
        public Numero GetLegajo()
        {
            return legajo;
        }
        public Numero GetPromedio()
        {
            return promedio;
        }
        public IEstrategiaAlumno GetEstrategia()
        {
            return this.estrategia;
        }
        public void SetEstrategia(IEstrategiaAlumno estrategia)
        {
            this.estrategia = estrategia;
        }
        //Override de implementacion de interfaz. En este caso comparo por el promedio del alumno, es mayor el que tiene mas nota
        public new bool SosMayor(IComparable elem)
        {
            return estrategia.SosMayor(this, elem);
        }
        public new bool SosMenor(IComparable elem)
        {
            return estrategia.SosMenor(this, elem);
        }
        public new bool SosIgual(IComparable elem)
        {
            return estrategia.SosIgual(this, elem); ;
        }
        public override string ToString()
        {
            return "Alumno: " + GetNombre() + " DNI: " + GetDni().ToString() + " Promedio: " + GetPromedio().GetValor().ToString() + " Legajo: " + GetLegajo().GetValor().ToString();
        }

    }
}
