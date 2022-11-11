namespace ProxyCommand
{
    class GeneradorDeDatosAleatorios
    {
        public GeneradorDeDatosAleatorios()
        {

        }
        public int NumeroAleatorio(int max)
        {
            Random numero = new Random();
            return numero.Next(0, max);
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
