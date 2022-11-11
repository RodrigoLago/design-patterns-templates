namespace AdapterDecorator
{
    public class Alumno : Persona, IEstudiante
    {
        private Numero legajo;
        private Numero promedio;
        private int calificacion;
        IEstrategiaAlumno estrategia;
        public Alumno(string nombre, int dni, int legajo, int promedio, int calificacion) : base(nombre, dni)
        {
            this.legajo = new Numero(legajo);
            this.promedio = new Numero(promedio);
            this.calificacion = calificacion;
            estrategia = new PorNombre();
        }
        public void SetCalificacion(int calificacion)
        {
            this.calificacion = calificacion;
        }
        public int GetLegajo()
        {
            return legajo.GetValor();
        }
        public Numero GetPromedio()
        {
            return promedio;
        }
        public int GetCalificacion()
        {
            return calificacion;
        }
        public IEstrategiaAlumno GetEstrategia()
        {
            return this.estrategia;
        }
        public void SetEstrategia(IEstrategiaAlumno estrategia)
        {
            this.estrategia = estrategia;
        }
        public virtual int ResponderPregunta(int pregunta)
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            return generador.NumeroAleatorio(3).GetValor();
        }
        public string MostrarCalificacion()
        {
            return this.GetNombre() + "    " + GetCalificacion();
        }
        //Override de implementacion de interfaz. En este caso comparo por el promedio del alumno, es mayor el que tiene mas nota
        public override bool SosMayor(IComparable elem)
        {
            return estrategia.SosMayor(this, elem);
        }
        public override bool SosMenor(IComparable elem)
        {
            return estrategia.SosMenor(this, elem);
        }
        public override bool SosIgual(IComparable elem)
        {
            return estrategia.SosIgual(this, elem); ;
        }
        public override string ToString()
        {
            return "Alumno: " + GetNombre() + " DNI: " + GetDni().ToString() + " Promedio: " + GetPromedio().GetValor().ToString() + " Legajo: " + GetLegajo().ToString();
        }

    }
}
