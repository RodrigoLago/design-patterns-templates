namespace ProxyCommand
{
    class Conjunto : IColeccionable, IIterable, IOrdenable
    {
        OrdenEnAula1 ordenInicio = null;
        OrdenEnAula2 ordenLlegaAlumno = null;
        OrdenEnAula1 ordenAulaLlena = null;

        private List<IComparable> lista = new List<IComparable>();
        public List<IComparable> GetLista()
        {
            return this.lista;
        }
        public void Agregar(IComparable elem)
        {
            if (!this.Contiene(elem))
            {
                lista.Add(elem);
            }
        }

        public bool Pertecene(IComparable elem)
        {
            if (this.GetLista().Count > 0)
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
        //Iterador
        public IIterator CrearIterador()
        {
            return new ConjuntoIterator(lista);
        }
        //Command
        public void SetOrdenInicio(OrdenEnAula1 ordenEnAula1)
        {
            ordenInicio = ordenEnAula1;
        }
        public void SetOrdenLlegaAlumno(OrdenEnAula2 ordenEnAula1)
        {
            ordenLlegaAlumno = ordenEnAula1;
        }
        public void SetOrdenAulaLlena(OrdenEnAula1 ordenEnAula1)
        {
            ordenAulaLlena = ordenEnAula1;
        }
    }
}
