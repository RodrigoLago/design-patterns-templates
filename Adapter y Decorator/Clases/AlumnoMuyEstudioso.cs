namespace AdapterDecorator
{
    class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, int promedio, int calificacion) : base(nombre, dni, legajo, promedio, calificacion)
        {
        }
        public override int ResponderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
