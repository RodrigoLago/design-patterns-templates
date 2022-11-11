namespace ProxyCommand
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
            return componente.GetNombre() + "  " + componente.GetCalificacion() + "  " + notas[componente.GetCalificacion()];
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
                return componente.GetNombre() + " PROMOCION";
            }
            else if (4 < componente.GetCalificacion() && componente.GetCalificacion() < 7)
            {
                return base.MostrarCalificacion() + " APROBADO";
            }
            else if (componente.GetCalificacion() < 4)
            {
                return componente.GetNombre() + " DESAPROBADO";
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
