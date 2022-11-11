namespace AdapterDecorator
{
    class PorBonus : IEstrategiaVendedor
    {
        public bool SosIgual(IComparable a1, IComparable a2)
        {
            return ((Vendedor)a1).GetBonus() == ((Vendedor)a2).GetBonus();
        }

        public bool SosMayor(IComparable a1, IComparable a2)
        {
            return ((Vendedor)a1).GetBonus() > ((Vendedor)a2).GetBonus();
        }

        public bool SosMenor(IComparable a1, IComparable a2)
        {
            return ((Vendedor)a1).GetBonus() < ((Vendedor)a2).GetBonus();
        }
    }
}
