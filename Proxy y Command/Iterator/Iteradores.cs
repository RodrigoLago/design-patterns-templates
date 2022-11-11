namespace ProxyCommand
{
    public interface IIterable
    {
        IIterator CrearIterador();
    }
    public interface IIterator
    {
        void Next();
        bool HasNext();
        object Current();

    }
}
