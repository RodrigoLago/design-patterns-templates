namespace FactoryObserver
{
    public class Vendedor : Persona, IComparable, IObservable
    {
        private Numero sueldoBasico;
        private double bonus;
        IEstrategiaVendedor estrategia;
        List<IObservador> observadores = new List<IObservador>();
        public Vendedor(string nombre, int dni, int sueldoBasico, double bonus) : base(nombre, dni)
        {
            this.sueldoBasico = new Numero(sueldoBasico);
            this.bonus = bonus;
            estrategia = new PorBonus();
        }
        public double GetBonus()
        {
            return this.bonus;
        }
        public int GetSueldo()
        {
            return this.sueldoBasico.GetValor();
        }
        public void Venta(int monto)
        {
            Console.WriteLine("***El vendedor " + this.GetNombre() + " hizo una venta por " + monto + " pesos***");
        }
        public void AumentaBonus()
        {
            bonus = bonus * 1.1;
        }
        public override string ToString()
        {
            return "Vendedor Nombre: " + this.GetNombre() + " Dni:" + this.GetDni() + " Sueldo: " + this.GetSueldo() + " Bonus: " + this.GetBonus();
        }
        public new bool SosIgual(IComparable elem)
        {
            return estrategia.SosIgual(this, elem);
        }
        public new bool SosMenor(IComparable elem)
        {
            return estrategia.SosMenor(this, elem);
        }
        public new bool SosMayor(IComparable elem)
        {
            return estrategia.SosMayor(this, elem);
        }

        public void Notificar()
        {
            foreach (IObservador gerente in observadores)
            {
                gerente.Actualizar(this);
            }
        }
        public void AgregarObservador(IObservador observador)
        {
            if (!observadores.Contains(observador))
            {
                observadores.Add(observador);
            }
        }
        public void QuitarObservador(IObservador observador)
        {
            if (observadores.Contains(observador))
            {
                observadores.Remove(observador);
            }
        }
    }
}
