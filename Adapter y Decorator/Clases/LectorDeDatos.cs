namespace AdapterDecorator
{
    class LectorDeDatos
    {
        public Numero NumeroLeido()
        {
            int numeroInt = int.Parse(Console.ReadLine());
            return new Numero(numeroInt);
        }
        public string StringLeido()
        {
            string stringLeido = Console.ReadLine();
            return stringLeido;
        }
    }
}
