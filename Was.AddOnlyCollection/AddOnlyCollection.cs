namespace Was.AddOnlyCollection
{
    using System.Collections;
    using System.Collections.Generic;

    public class AddOnlyCollection<T> : IAddOnlyCollection<T>, IEnumerable<T>
    {
        private readonly LinkedList<T> underlyingList;

        public AddOnlyCollection()
        {
            this.underlyingList = new LinkedList<T>();
        }

        public bool Add(T element)
        {
            this.underlyingList.AddLast(element);
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.underlyingList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
