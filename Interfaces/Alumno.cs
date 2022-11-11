namespace Interfaces
{
    public class Alumno : Persona
    {
        Numero Legajo { get; set; }
        Numero Promedio { get; set; }
        public Alumno(string nombre, Numero dni, Numero legajo, Numero promedio) : base(nombre, dni)
        {
            Legajo = legajo;
            Promedio = promedio;
        }
    }
}
