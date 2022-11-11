namespace FactoryObserver
{
    public class ColeccionMultiple : IColeccionable
    {
        Cola cola = new();
        Pila pila = new();
        public ColeccionMultiple(Cola c, Pila p)
        {
            cola = c;
            pila = p;
        }
        // Interfaz IColeccionable
        public void Agregar(IComparable elem)
        {
            //Agregar no hace nada
            throw new NotImplementedException();
        }

        public bool Contiene(IComparable elem)
        {
            if (cola.Contiene(elem) || pila.Contiene(elem))
                return true;
            else
                return false;
        }

        public int Cuantos()
        {
            return pila.Cuantos() + cola.Cuantos();
        }

        public IComparable Maximo()
        {
            IComparable a = cola.Maximo();
            IComparable b = pila.Maximo();
            if (a.SosMayor(b))
                return a;
            else
                return b;
        }

        public IComparable Minimo()
        {
            IComparable a = cola.Minimo();
            IComparable b = pila.Minimo();
            if (a.SosMenor(b))
                return a;
            else
                return b;
        }
    }
}
