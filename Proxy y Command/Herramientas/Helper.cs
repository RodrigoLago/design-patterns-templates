namespace ProxyCommand
{
    public class Helper
    {
        public static void Clase()
        {

            Teacher profesor = new Teacher();

            for (int i = 0; i < 10; i++)
            {
                //Aca se implementa el decorator y el adapter
                IEstudiante alumno = (AlumnoProxy)FabricaDeComparables.CrearAleatorio(3);
                IEstudiante estudiante = new NotaYLegajo(alumno);
                //estudiante = new NotaEnLetras(estudiante);
                //estudiante = new NotaAprobadoODesaprbado(estudiante);
                estudiante = new NotaEnAsteriscos(estudiante);
                profesor.GoToClass(new AdaptadorAlumno(estudiante));
            }
            for (int i = 0; i < 10; i++)
            {
                IEstudiante alumnoMuyEstudioso = (AlumnoMuyEstudiosoProxy)FabricaDeComparables.CrearAleatorio(4);
                IEstudiante estudiante = new NotaYLegajo(alumnoMuyEstudioso);
                //estudiante = new NotaEnLetras(estudiante);
                //estudiante = new NotaAprobadoODesaprbado(estudiante);
                estudiante = new NotaEnAsteriscos(estudiante);
                profesor.GoToClass(new AdaptadorAlumno(estudiante));
            }
            profesor.TeachingAClass();
        }
        public static void Llenar(IColeccionable coleccion, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                IComparable comparable = FabricaDeComparables.CrearAleatorio(opcion);
                coleccion.Agregar(comparable);
            }
        }
        public static void InformarElementos(IIterable coleccionIterable)
        {
            IIterator iter = coleccionIterable.CrearIterador();
            while (iter.HasNext())
            {
                Console.WriteLine(iter.Current());
                iter.Next();
            }
        }
        public static void Informar(IColeccionable coleccion, int opcion)
        {
            Console.WriteLine("\nCantidad elementos: " + coleccion.Cuantos());
            Console.WriteLine("Elemento mas chico: " + coleccion.Minimo());
            Console.WriteLine("Elemento mas grande: " + coleccion.Maximo());
            Console.WriteLine("Ingrese su Comparable y le dire si existe en la coleccion ");
            IComparable comparable = FabricaDeComparables.CrearPorTeclado(opcion);
            if (coleccion.Contiene(comparable))
            {
                Console.WriteLine("Su coleccion contiene el elemento");
            }
            else
            {
                Console.WriteLine("Su coleccion NO contiene el elemento");
            }

        }
        public static void JornadaDeVentas(IIterable coleccionIterable)
        {
            Random random = new Random();
            IIterator iter = coleccionIterable.CrearIterador();
            while (iter.HasNext())
            {
                int monto = random.Next(1, 7000);
                ((Vendedor)iter.Current()).Venta(monto);
                ((Vendedor)iter.Current()).Notificar();
                iter.Next();
            }
        }
        public static void LlenarGerentes(IIterable pila, Gerente gerente)
        {
            IIterator iter = pila.CrearIterador();
            while (iter.HasNext())
            {
                ((Vendedor)iter.Current()).AgregarObservador(gerente);
                iter.Next();
            }
        }
        public static void SetearOrdenes()
        {
            Pila pila = new Pila();
            Aula aula = new Aula();
            pila.SetOrdenInicio(new OrdenInicio(aula));
            pila.SetOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            pila.SetOrdenAulaLlena(new OrdenAulaLlena(aula));
            Llenar(pila, 3);
            Llenar(pila, 4);
        }
    }
}
