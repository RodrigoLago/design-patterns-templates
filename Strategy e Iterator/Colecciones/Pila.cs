namespace StrategyIterator
{
    public class Pila : IColeccionable, IIterable
    {
        private List<IComparable> pila = new();

        public void Apilar(IComparable elem)
        {
            this.pila.Add(elem);
        }

        public IComparable Desapilar()
        {
            IComparable temp = this.pila[pila.Count - 1];
            this.pila.RemoveAt(pila.Count - 1);
            return temp;
        }

        public IComparable Tope()
        {
            return this.pila[pila.Count - 1];
        }

        public bool EsVacia()
        {
            return this.pila.Count == 0;
        }

        public int Cuantos()
        {
            return pila.Count;
        }

        public IComparable Minimo()
        {
            IComparable aux = pila[0];
            for (int i = 1; i < pila.Count; i++)
            {
                if (pila[i].SosMenor(aux))
                {
                    aux = pila[i];
                }
            }
            return aux;
        }

        public IComparable Maximo()
        {
            IComparable aux = pila[0];
            for (int i = 1; i < pila.Count; i++)
            {
                if (pila[i].SosMayor(aux))
                {
                    aux = pila[i];
                }
            }
            return aux;
        }

        public void Agregar(IComparable elem)
        {
            this.Apilar(elem);
        }

        public bool Contiene(IComparable elem)
        {
            for (int i = 0; i < pila.Count; i++)
            {
                if (pila[i].SosIgual(elem))
                {
                    return true;
                }
            }
            return false;
        }

        public IIterator CrearIterador()
        {
            return new PilaIterator(pila);
        }
    }
}
