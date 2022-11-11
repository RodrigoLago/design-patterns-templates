namespace ProxyCommand
{
    public class Cola : IColeccionable, IIterable, IOrdenable
    {
        OrdenEnAula1 ordenInicio = null;
        OrdenEnAula2 ordenLlegaAlumno = null;
        OrdenEnAula1 ordenAulaLlena = null;

        private List<IComparable> cola = new List<IComparable>();

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
            if (cola.Count == 0 && ordenInicio != null)
            {
                ordenInicio.Ejecutar();
            }
            if (ordenLlegaAlumno != null)
            {
                ordenLlegaAlumno.Ejecutar(elem);
            }

            cola.Add(elem);

            if (ordenAulaLlena != null && cola.Count == 40)
            {
                ordenAulaLlena.Ejecutar();
            }
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
        //Iterador
        public IIterator CrearIterador()
        {
            return (new ColaIterator(cola));
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

