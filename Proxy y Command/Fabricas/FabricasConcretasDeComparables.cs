namespace ProxyCommand
{
    public class FabricaDeVendedores : FabricaDeComparables
    {
        public override IComparable CrearAleatorio()
        {
            Random random = new Random();
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            string nombre = generador.StringAleatorio(random.Next(5, 10));
            int dni = generador.NumeroAleatorio(100000000);
            int sueldo = generador.NumeroAleatorio(3000);
            int bonus = generador.NumeroAleatorio(10000);
            return new Vendedor(nombre, dni, sueldo, bonus);
        }
        public override IComparable CrearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();

            Console.Write("Nombre: ");
            string nombre = lector.StringLeido();

            Console.Write("Dni: ");
            int dni = lector.NumeroLeido();

            Console.Write("Sueldo Basico: ");
            int sueldoBasico = lector.NumeroLeido();

            Console.Write("Bonus: ");
            int bonus = lector.NumeroLeido();

            return new Vendedor(nombre, dni, sueldoBasico, bonus);
        }
    }
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        public override IComparable CrearAleatorio()
        {
            Random random = new Random();
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            string nombre = generador.StringAleatorio(random.Next(5, 10));
            int dni = generador.NumeroAleatorio(100000000);
            int legajo = generador.NumeroAleatorio(3000);
            int promedio = generador.NumeroAleatorio(10000);
            int calificacion = generador.NumeroAleatorio(100);
            //return new Alumno(nombre,dni,legajo,promedio,calificacion);
            return new Alumno(nombre, dni, legajo, promedio, calificacion);
        }
        public override IComparable CrearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();

            Console.Write("Nombre: ");
            string nombre = lector.StringLeido();

            Console.Write("Dni: ");
            int dni = lector.NumeroLeido();

            Console.Write("Legajo: ");
            int legajo = lector.NumeroLeido();

            Console.Write("Promedio: ");
            int promedio = lector.NumeroLeido();

            Console.Write("Calificacion: ");
            int calificacion = lector.NumeroLeido();

            return new Alumno(nombre, dni, legajo, promedio, calificacion);
        }
    }
    public class FabricaDeAlumnosEstudiosos : FabricaDeComparables
    {
        public override IComparable CrearAleatorio()
        {
            Random random = new Random();
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            string nombre = generador.StringAleatorio(random.Next(5, 10));
            int dni = generador.NumeroAleatorio(100000000);
            int legajo = generador.NumeroAleatorio(3000);
            int promedio = generador.NumeroAleatorio(10000);
            int calificacion = generador.NumeroAleatorio(100);
            return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio, calificacion);
        }
        public override IComparable CrearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();

            Console.Write("Nombre: ");
            string nombre = lector.StringLeido();

            Console.Write("Dni: ");
            int dni = lector.NumeroLeido();

            Console.Write("Legajo: ");
            int legajo = lector.NumeroLeido();

            Console.Write("Promedio: ");
            int promedio = lector.NumeroLeido();

            Console.Write("Calificacion: ");
            int calificacion = lector.NumeroLeido();

            return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio, calificacion);
        }
    }
    public class FabricaDeAlumnosProxy : FabricaDeComparables
    {
        public override IComparable CrearAleatorio()
        {
            Random random = new Random();
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            string nombre = generador.StringAleatorio(random.Next(5, 10));
            int dni = generador.NumeroAleatorio(100000000);
            int legajo = generador.NumeroAleatorio(3000);
            int promedio = generador.NumeroAleatorio(10000);
            int calificacion = generador.NumeroAleatorio(100);
            return new AlumnoProxy(nombre, dni, legajo, promedio, calificacion);

        }
        public override IComparable CrearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();

            Console.Write("Nombre: ");
            string nombre = lector.StringLeido();

            Console.Write("Dni: ");
            int dni = lector.NumeroLeido();

            Console.Write("Legajo: ");
            int legajo = lector.NumeroLeido();

            Console.Write("Promedio: ");
            int promedio = lector.NumeroLeido();

            Console.Write("Calificacion: ");
            int calificacion = lector.NumeroLeido();

            return new AlumnoProxy(nombre, dni, legajo, promedio, calificacion);
        }
    }
    public class FabricaDeAlumnosMuyEstudiososProxy : FabricaDeComparables
    {
        public override IComparable CrearAleatorio()
        {
            Random random = new Random();
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            string nombre = generador.StringAleatorio(random.Next(5, 10));
            int dni = generador.NumeroAleatorio(100000000);
            int legajo = generador.NumeroAleatorio(3000);
            int promedio = generador.NumeroAleatorio(10000);
            int calificacion = generador.NumeroAleatorio(100);
            return new AlumnoMuyEstudiosoProxy(nombre, dni, legajo, promedio, calificacion);
        }
        public override IComparable CrearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();

            Console.Write("Nombre: ");
            string nombre = lector.StringLeido();

            Console.Write("Dni: ");
            int dni = lector.NumeroLeido();

            Console.Write("Legajo: ");
            int legajo = lector.NumeroLeido();

            Console.Write("Promedio: ");
            int promedio = lector.NumeroLeido();

            Console.Write("Calificacion: ");
            int calificacion = lector.NumeroLeido();

            return new AlumnoMuyEstudiosoProxy(nombre, dni, legajo, promedio, calificacion);
        }
    }
}
