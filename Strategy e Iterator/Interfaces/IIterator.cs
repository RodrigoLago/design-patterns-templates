namespace StrategyIterator
{
    public interface IIterator
    {
        void Next();
        bool HasNext();
        object Current();

    }
}
