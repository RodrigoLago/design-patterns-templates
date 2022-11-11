namespace AdapterDecorator
{
    public interface IEstudiante : IComparable
    {
        public string GetNombre();
        public Numero GetDni();
        public Numero GetPromedio();
        public int ResponderPregunta(int pregunta);
        public void SetCalificacion(int calificacion);
        public int GetCalificacion();
        public string MostrarCalificacion();
        public int GetLegajo();

    }
}
