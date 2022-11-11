namespace AdapterDecorator
{
    public interface IObservable
    {
        public void Notificar();
        public void AgregarObservador(IObservador observador);
        public void QuitarObservador(IObservador observador);
    }
    public interface IObservador
    {
        public void Actualizar(IObservable observable);
    }
}
