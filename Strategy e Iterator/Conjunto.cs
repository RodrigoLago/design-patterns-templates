using Strategy_e_Iterator.Interfaces;
using IComparable = Strategy_e_Iterator.Interfaces.IComparable;

namespace Strategy_e_Iterator
{
    public class Conjunto : IColeccionable
    {
        public List<IComparable> List = new();
        public void Agregar (IComparable comparable)
        {
            if (!this.Contiene(comparable))
            List.Add(comparable);
        }

        public bool Contiene(IComparable comparable)
        {
            if (this.List.Count > 0)
            {
                foreach (IComparable comp in this.List)
                {
                    if (comp.SosIgual(comparable))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int Cuantos()
        {
            return List.Count;
        }

        public IComparable Maximo()
        {
            IComparable aux = List[0];
            foreach (var item in List)
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
            IComparable aux = List[0];
            foreach (var item in List)
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
