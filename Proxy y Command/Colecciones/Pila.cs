namespace ProxyCommand
{
    public class Pila : IColeccionable, IIterable, IOrdenable
    {
        OrdenEnAula1 ordenInicio = null;
        OrdenEnAula2 ordenLlegaAlumno = null;
        OrdenEnAula1 ordenAulaLlena = null;

        private List<IComparable> pila = new List<IComparable>();

        public void Apilar(IComparable elem)
        {
            if (pila.Count == 0 && ordenInicio != null)
            {
                ordenInicio.Ejecutar();
            }
            if (ordenLlegaAlumno != null)
            {
                ordenLlegaAlumno.Ejecutar(elem);
            }

            pila.Add(elem);

            if (ordenAulaLlena != null && pila.Count == 40)
            {
                ordenAulaLlena.Ejecutar();
            }
        }

        public IComparable Desapilar()
        {
            IComparable temp = this.pila[this.pila.Count - 1];
            this.pila.RemoveAt(this.pila.Count - 1);
            return temp;
        }

        public IComparable Tope()
        {
            return this.pila[this.pila.Count - 1];
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
        //Iterador
        public IIterator CrearIterador()
        {
            return new PilaIterator(pila);
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
