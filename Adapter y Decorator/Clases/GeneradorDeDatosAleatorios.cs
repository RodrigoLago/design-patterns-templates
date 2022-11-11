namespace AdapterDecorator
{
    class GeneradorDeDatosAleatorios
    {
        public GeneradorDeDatosAleatorios()
        {

        }
        public Numero NumeroAleatorio(int max)
        {
            Random numero = new Random();
            int numeroInt = numero.Next(0, max);
            return new Numero(numeroInt);
        }
        public string StringAleatorio(int cant)
        {
            Random cadena = new Random();
            string cadenaLlena = null;
            for (int i = 0; i < cant; i++)
            {
                char randomChar = (char)cadena.Next('a', 'z');

                cadenaLlena += randomChar;
            }
            return cadenaLlena;
        }
    }
}
