namespace Strategy_e_Iterator
{
    public  class Diccionario : IColeccionable, IIterable
    {
        private Conjunto conjunto;
        private Numero clave = new Numero(0);
        public Diccionario()
        {
            this.conjunto = new Conjunto();
        }
        public Conjunto GetConjunto()
        {
            return this.conjunto;
        }

        public void Agregar(IComparable valor)
        {
            bool seModifico = false;
            ClaveValor claveValor = new ClaveValor(clave, valor);
            foreach (ClaveValor item in conjunto.GetLista())
            {
                if (item.GetClave().SosIgual(clave))
                {
                    item.SetValor(valor);
                    seModifico = true;
                    break;
                }
            }
            if (!seModifico)
            {
                conjunto.Agregar(claveValor);
            }
            clave = new Numero(clave.Valor + 1);
        }
        public object ValorDe(IComparable clave)
        {
            foreach (ClaveValor item in conjunto.GetLista())
            {
                if (item.GetClave().SosIgual(clave))
                {
                    return item.GetValor();
                }
            }
            return "No se encontró la clave";
        }

        public int Cuantos()
        {
            return conjunto.Cuantos();
        }

        public IComparable Minimo()
        {
            return conjunto.Minimo();
        }

        public IComparable Maximo()
        {
            return conjunto.Maximo();
        }

        public bool Contiene(IComparable elem)
        {
            return conjunto.Contiene(elem);
        }

        public IIterator CrearIterador()
        {
            return new DiccionarioIterator(conjunto);
        }
    }
}
