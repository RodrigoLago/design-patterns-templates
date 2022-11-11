namespace ProxyCommand
{
    public interface IEstudiante : IComparable
    {
        public string GetNombre();
        public int GetDni();
        public int GetPromedio();
        public int ResponderPregunta(int pregunta);
        public void SetCalificacion(int calificacion);
        public int GetCalificacion();
        public string MostrarCalificacion();
        public int GetLegajo();

    }
}
