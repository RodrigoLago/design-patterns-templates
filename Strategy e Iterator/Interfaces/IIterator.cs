namespace Strategy_e_Iterator
{
    public interface IIterator
    {
        void Next();
        bool HasNext();
        object Current();

    }
}
