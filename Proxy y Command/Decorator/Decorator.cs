namespace ProxyCommand
{
    public abstract class Decorador : IEstudiante
    {
        protected IEstudiante componente;
        public Decorador(IEstudiante componente)
        {
            this.componente = componente;
        }

        public virtual int GetCalificacion()
        {
            return componente.GetCalificacion();
        }

        public int GetDni()
        {
            return componente.GetDni();
        }

        public virtual int GetLegajo()
        {
            return componente.GetLegajo();
        }

        public virtual string GetNombre()
        {
            return componente.GetNombre();
        }

        public int GetPromedio()
        {
            return componente.GetPromedio();
        }

        public virtual string MostrarCalificacion()
        {
            return componente.MostrarCalificacion();
        }

        public virtual int ResponderPregunta(int pregunta)
        {
            return componente.ResponderPregunta(pregunta);
        }

        public virtual void SetCalificacion(int calificacion)
        {
            this.componente.SetCalificacion(calificacion);
        }

        public virtual bool SosIgual(IComparable elem)
        {
            return componente.SosIgual(elem);
        }

        public virtual bool SosMayor(IComparable elem)
        {
            return componente.SosMayor(elem);
        }

        public virtual bool SosMenor(IComparable elem)
        {
            return componente.SosMenor(elem);
        }
    }
}
