namespace Strategy_e_Iterator
{
    public class Numero : IComparable
    {
        public int Valor { get; set; }
        public Numero(int valor)
        {
            this.Valor = valor;
        }

        public bool SosIgual(IComparable comparable)
        {
            return this.Valor == ((Numero)comparable).Valor;
        }

        public bool SosMayor(IComparable comparable)
        {
            return this.Valor > ((Numero)comparable).Valor;
        }

        public bool SosMenor(IComparable comparable)
        {
            return this.Valor < ((Numero)comparable).Valor;
        }
        public override string ToString()
        {
            return Valor.ToString();
        }
    }
}
