namespace ProxyCommand
{
    public class AlumnoProxy : IEstudiante
    {
        IEstudiante alumno = null;
        private int dni;
        private string nombre;
        private int legajo;
        private int promedio;
        private int calificacion;
        public AlumnoProxy(string nombre, int dni, int legajo, int promedio, int calificacion)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.legajo = legajo;
            this.promedio = promedio;
            this.calificacion = calificacion;
        }
        //Metodo al cual hay que aplicarle proxy
        public int ResponderPregunta(int pregunta)
        {
            if (alumno == null)
            {
                Console.Write("*Mensaje Proxy* Se instancia un Alumno porque debe responder:          ");
                alumno = (IEstudiante)FabricaDeComparables.CrearAleatorio(1);
                alumno.SetCalificacion(calificacion);
            }
            return alumno.ResponderPregunta(pregunta);
        }

        public int GetCalificacion()
        {
            return alumno.GetCalificacion();
        }

        public int GetDni()
        {
            return alumno.GetDni();
        }

        public int GetLegajo()
        {
            return alumno.GetLegajo();
        }

        public string GetNombre()
        {
            if (alumno == null)
            {
                return "***No tengo nombre porque aun no me cree***";
            }
            else
            {
                return alumno.GetNombre();
            }
        }

        public int GetPromedio()
        {
            return alumno.GetPromedio();
        }

        public string MostrarCalificacion()
        {
            return alumno.MostrarCalificacion();
        }


        public void SetCalificacion(int calificacion)
        {
            alumno.SetCalificacion(calificacion);
        }

        public bool SosIgual(IComparable elem)
        {
            return alumno.SosIgual(elem);
        }

        public bool SosMayor(IComparable elem)
        {
            return alumno.SosMayor(elem);
        }

        public bool SosMenor(IComparable elem)
        {
            return alumno.SosMenor(elem);
        }
    }
    public class AlumnoMuyEstudiosoProxy : IEstudiante
    {
        IEstudiante alumno = null;
        private int dni;
        private string nombre;
        private int legajo;
        private int promedio;
        private int calificacion;
        public AlumnoMuyEstudiosoProxy(string nombre, int dni, int legajo, int promedio, int calificacion)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.legajo = legajo;
            this.promedio = promedio;
            this.calificacion = calificacion;
        }
        //Metodo al cual hay que aplicarle proxy
        public int ResponderPregunta(int pregunta)
        {
            if (alumno == null)
            {
                Console.Write("*Mensaje Proxy* Se instancia un AlumnoMuyEstudioso porque debe responder: ");
                alumno = (IEstudiante)FabricaDeComparables.CrearAleatorio(2);
                alumno.SetCalificacion(calificacion);
            }
            return alumno.ResponderPregunta(pregunta);
        }


        public int GetCalificacion()
        {
            return alumno.GetCalificacion();
        }

        public int GetDni()
        {
            return alumno.GetDni();
        }

        public int GetLegajo()
        {
            return alumno.GetLegajo();
        }

        public string GetNombre()
        {
            if (alumno == null)
            {
                //Console.Write("***Mensaje Proxy*** Hay necesidad de instanciar un Alumno:                     ");
                return "***No tengo nombre porque aun no me cree***";
            }
            return alumno.GetNombre();
        }

        public int GetPromedio()
        {
            return alumno.GetPromedio();
        }

        public string MostrarCalificacion()
        {
            return alumno.MostrarCalificacion();
        }


        public void SetCalificacion(int calificacion)
        {
            alumno.SetCalificacion(calificacion);
        }

        public bool SosIgual(IComparable elem)
        {
            return alumno.SosIgual(elem);
        }

        public bool SosMayor(IComparable elem)
        {
            return alumno.SosMayor(elem);
        }

        public bool SosMenor(IComparable elem)
        {
            return alumno.SosMenor(elem);
        }
    }
}
