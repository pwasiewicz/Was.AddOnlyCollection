namespace Was.AddOnlyCollection
{
    public interface IAddOnlyCollection<in T>
    {
        bool Add(T element);
    }
}
