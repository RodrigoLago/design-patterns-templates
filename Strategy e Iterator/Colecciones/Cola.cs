namespace Strategy_e_Iterator
{
    public class Cola : IColeccionable, IIterable
    {
        private List<IComparable> cola = new();

        public void Encolar(IComparable elem)
        {
            this.cola.Add(elem);
        }

        public IComparable Desencolar()
        {
            IComparable temp = this.cola[0];
            this.cola.RemoveAt(0);
            return temp;
        }

        public IComparable Tope()
        {
            return this.cola[0];
        }

        public bool EsVacia()
        {
            return this.cola.Count == 0;
        }

        public int Cuantos()
        {
            return cola.Count;
        }

        public IComparable Minimo()
        {
            IComparable aux = cola[0];
            for (int i = 1; i < cola.Count; i++)
            {
                if (cola[i].SosMenor(aux))
                {
                    aux = cola[i];
                }
            }
            return aux;
        }

        public IComparable Maximo()
        {
            IComparable aux = cola[0];
            for (int i = 1; i < cola.Count; i++)
            {
                if (cola[i].SosMayor(aux))
                {
                    aux = cola[i];
                }
            }
            return aux;
        }

        public void Agregar(IComparable elem)
        {
            this.Encolar(elem);
        }

        public bool Contiene(IComparable elem)
        {
            for (int i = 0; i < cola.Count; i++)
            {
                if (cola[i].SosIgual(elem))
                {
                    return true;
                }
            }
            return false;
        }

        public IIterator CrearIterador()
        {
            return (new ColaIterator(cola));
        }
    }
}

