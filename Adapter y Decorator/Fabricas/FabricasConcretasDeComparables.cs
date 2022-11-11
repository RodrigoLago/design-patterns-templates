namespace AdapterDecorator
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Numero CrearAleatorio()
        {
            GeneradorDeDatosAleatorios generar = new GeneradorDeDatosAleatorios();
            Random numeroRandom = new Random();
            return new Numero(generar.NumeroAleatorio(numeroRandom.Next()).GetValor());
        }
        public override Numero CrearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();
            Console.WriteLine("Ingrese un numero");
            int numero = lector.NumeroLeido().GetValor();
            return new Numero(numero);
        }
    }
    public class FabricaDeVendedores : FabricaDeComparables
    {
        public override IComparable CrearAleatorio()
        {
            Random random = new Random();
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            string nombre = generador.StringAleatorio(random.Next(5, 10));
            int dni = generador.NumeroAleatorio(100000000).GetValor();
            int sueldo = generador.NumeroAleatorio(3000).GetValor();
            int bonus = generador.NumeroAleatorio(10000).GetValor();
            return new Vendedor(nombre, dni, sueldo, bonus);
        }
        public override IComparable CrearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();

            Console.Write("Nombre: ");
            string nombre = lector.StringLeido();

            Console.Write("Dni: ");
            int dni = lector.NumeroLeido().GetValor();

            Console.Write("Sueldo Basico: ");
            int sueldoBasico = lector.NumeroLeido().GetValor();

            Console.Write("Bonus: ");
            int bonus = lector.NumeroLeido().GetValor();

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
            int dni = generador.NumeroAleatorio(100000000).GetValor();
            int legajo = generador.NumeroAleatorio(3000).GetValor();
            int promedio = generador.NumeroAleatorio(10000).GetValor();
            int calificacion = generador.NumeroAleatorio(100).GetValor();
            return new Alumno(nombre, dni, legajo, promedio, calificacion);
        }
        public override IComparable CrearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();

            Console.Write("Nombre: ");
            string nombre = lector.StringLeido();

            Console.Write("Dni: ");
            int dni = lector.NumeroLeido().GetValor();

            Console.Write("Legajo: ");
            int legajo = lector.NumeroLeido().GetValor();

            Console.Write("Promedio: ");
            int promedio = lector.NumeroLeido().GetValor();

            Console.Write("Calificacion: ");
            int calificacion = lector.NumeroLeido().GetValor();

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
            int dni = generador.NumeroAleatorio(100000000).GetValor();
            int legajo = generador.NumeroAleatorio(3000).GetValor();
            int promedio = generador.NumeroAleatorio(10000).GetValor();
            int calificacion = generador.NumeroAleatorio(100).GetValor();
            return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio, calificacion);
        }
        public override IComparable CrearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();

            Console.Write("Nombre: ");
            string nombre = lector.StringLeido();

            Console.Write("Dni: ");
            int dni = lector.NumeroLeido().GetValor();

            Console.Write("Legajo: ");
            int legajo = lector.NumeroLeido().GetValor();

            Console.Write("Promedio: ");
            int promedio = lector.NumeroLeido().GetValor();

            Console.Write("Calificacion: ");
            int calificacion = lector.NumeroLeido().GetValor();

            return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio, calificacion);
        }
    }
}
