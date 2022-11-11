namespace ProxyCommand
{
    public class Numero : IComparable
    {
        private int valor;
        public Numero(int v)
        {
            valor = v;
        }
        public override string ToString()
        {
            return valor.ToString();
        }
        public int GetValor()
        {
            return valor;
        }
        //Interfaz Comparable
        public bool SosIgual(IComparable elem)
        {
            if (this.GetValor() == ((Numero)elem).GetValor())
                return true;
            else
                return false;
        }

        public bool SosMayor(IComparable elem)
        {
            if (this.GetValor() > ((Numero)elem).GetValor())
                return true;
            else
                return false;
        }

        public bool SosMenor(IComparable elem)
        {
            if (this.GetValor() < ((Numero)elem).GetValor())
                return true;
            else
                return false;
        }
    }
}
