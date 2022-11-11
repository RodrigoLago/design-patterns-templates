namespace AdapterDecorator
{
    public class NotaYLegajo : Decorador
    {
        public NotaYLegajo(IEstudiante componente) : base(componente)
        {
        }
        public override string MostrarCalificacion()
        {
            return componente.GetNombre() + "   (" + componente.GetLegajo() + ")   " + componente.GetCalificacion();
        }
    }
    public class NotaEnLetras : Decorador
    {
        string[] notas = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
        public NotaEnLetras(IEstudiante componente) : base(componente)
        {
        }
        public override string MostrarCalificacion()
        {
            return base.MostrarCalificacion() + "  " + notas[componente.GetCalificacion()];
        }
    }
    public class NotaAprobadoODesaprbado : Decorador
    {
        public NotaAprobadoODesaprbado(IEstudiante componente) : base(componente)
        {
        }
        public override string MostrarCalificacion()
        {
            if (componente.GetCalificacion() > 6)
            {
                return base.MostrarCalificacion() + " PROMOCION";
            }
            else if (componente.GetCalificacion() > 3 && componente.GetCalificacion() < 7)
            {
                return base.MostrarCalificacion() + " APROBADO";
            }
            else if (componente.GetCalificacion() < 4)
            {
                return base.MostrarCalificacion() + " DESAPROBADO";
            }
            else
            {
                return componente.GetNombre();
            }
        }
    }
    public class NotaEnAsteriscos : Decorador
    {
        public NotaEnAsteriscos(IEstudiante componente) : base(componente)
        {
        }
        public override string MostrarCalificacion()
        {
            string asteriscos = "************************************************";
            asteriscos += "\n*" + base.MostrarCalificacion();
            asteriscos += "*\n************************************************\n";
            return asteriscos;
        }
    }
}
