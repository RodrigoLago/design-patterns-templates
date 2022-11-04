namespace FactoryObserver
{
    public class Helper
    {
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
            Random random = new();
            IIterator iter = coleccionIterable.CrearIterador();
            while (iter.HasNext())
            {
                int monto = random.Next(1, 7000);
                ((Vendedor)iter.Current()).Venta(monto);
                ((Vendedor)iter.Current()).Notificar();
                iter.Next();
            }
        }
    }
}
