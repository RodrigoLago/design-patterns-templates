namespace ProxyCommand
{
    public abstract class FabricaDeComparables
    {
        public abstract IComparable CrearAleatorio();
        public abstract IComparable CrearPorTeclado();
        public static IComparable CrearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 2:
                    fabrica = new FabricaDeAlumnosEstudiosos();
                    break;
                case 3:
                    fabrica = new FabricaDeAlumnosProxy();
                    break;
                case 4:
                    fabrica = new FabricaDeAlumnosMuyEstudiososProxy();
                    break;
                default:
                    break;
            }
            return fabrica.CrearAleatorio();
        }

        public static IComparable CrearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1:
                    break;
                case 2:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 3:
                    fabrica = new FabricaDeAlumnosEstudiosos();
                    break;
                case 4:
                    fabrica = new FabricaDeVendedores();
                    break;
                default:
                    break;
            }
            return fabrica.CrearPorTeclado();
        }

    }
}
