namespace FactoryObserver
{
    public class Conjunto : IColeccionable,IIterable
    {
        private List<IComparable> lista = new List<IComparable>();
        public List<IComparable> GetLista()
        {
            return this.lista;
        }
        public void Agregar(IComparable elem)
        {
            if (!this.Contiene(elem)){
                lista.Add(elem);
            }
        }

        public bool Pertecene(IComparable elem)
        {
            if (this.GetLista().Count>0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (this.GetLista()[i].SosIgual(elem))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool Contiene(IComparable elem)
        {
            if (lista.Count > 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].SosIgual(elem))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int Cuantos()
        {
            return lista.Count;
        }

        public IComparable Minimo()
        {
            IComparable aux = lista[0];
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i].SosMenor(aux))
                {
                    aux = lista[i];
                }
            }
            return aux;
        }

        public IComparable Maximo()
        {
            IComparable aux = lista[0];
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i].SosMayor(aux))
                {
                    aux = lista[i];
                }
            }
            return aux;
        }

        public IIterator CrearIterador()
        {
            return new ConjuntoIterator(lista);
        }
    }
}
