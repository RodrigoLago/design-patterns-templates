namespace interfaces
{
    public class Pila : IColeccionable
    {
       private List<IComparable> _items = new List<IComparable>();

        public void Agregar(IComparable comparable)
        {
            _items.Add(comparable);
        }

        public bool Contiene(IComparable comparable)
        {
            foreach (var item in _items)
            {
                if (item.SosIgual(comparable))
                {
                    return true;
                }
            }
            return false;
        }

        public int Cuantos()
        {
            return _items.Count;
        }

        public IComparable Maximo()
        {
            IComparable aux = _items[0];
            foreach (var item in _items)
            {
                if (item.SosMayor(aux))
                {
                    aux = item;
                }
            }
            return aux;
        }

        public IComparable Minimo()
        {
            IComparable aux = _items[0];
            foreach (var item in _items)
            {
                if (item.SosMenor(aux))
                {
                    aux = item;
                }
            }
            return aux;
        }
    }
}
