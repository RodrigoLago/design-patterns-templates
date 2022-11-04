namespace FactoryObserver
{
    class ClaveValor : IComparable
    {
        IComparable clave;
        object valor;
        public ClaveValor(IComparable clave, object valor)
        {
            this.clave = clave;
            this.valor = valor;
        }
        public IComparable GetClave()
        {
            return clave;
        }

        public object GetValor()
        {
            return valor;
        }
        public void SetValor(object valor)
        {
            this.valor = valor;
        }

        public bool SosIgual(IComparable elem)
        {
            return this.clave.SosIgual(((ClaveValor)elem).GetClave());
        }

        public bool SosMayor(IComparable elem)
        {
            return this.clave.SosMayor(((ClaveValor)elem).GetClave());
        }

        public bool SosMenor(IComparable elem)
        {
            return this.clave.SosMenor(((ClaveValor)elem).GetClave());
        }
        public override string ToString()
        {
            return "Clave: "+this.GetClave().ToString() +" Valor: "+ this.GetValor().ToString();
        }
    }
}
