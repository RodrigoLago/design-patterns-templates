namespace FactoryObserver
{
    public class Gerente : IObservador
    {
        public string nombre;
        List<IObservable> mejores = new();
        public Gerente(string nombre)
        {
            this.nombre = nombre;
        }
        public void Cerrar()
        {
            foreach (Vendedor vendedor in mejores)
            {
                Console.WriteLine("El vendedor " + vendedor.GetNombre() + " tuvo de bonus: " + vendedor.GetBonus());
            }
        }
        public void Venta(double monto, IObservable vendedor)
        {
            if (monto > 5000)
            {
                if (!mejores.Contains(vendedor))
                {
                    mejores.Add(vendedor);
                }
                ((Vendedor)vendedor).AumentaBonus();
            }
        }
        public void Actualizar(IObservable observado)
        {
            double monto = ((Vendedor)observado).GetBonus();
            this.Venta(monto, (Vendedor)observado);
        }

    }
}
