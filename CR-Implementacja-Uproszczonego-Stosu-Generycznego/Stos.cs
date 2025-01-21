using StrukturaStos;
using System.Collections.Generic;

namespace StrukturaStos
{
    public class Stos<T>: IStos<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item) => items.Add(item);
        public T Pop()
        {
            if (items.Count > 0)
            {
                T item = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);
                return item;
            }
            throw new StosEmptyException();
        }
        public T Peek => !IsEmpty ? items[items.Count - 1] : throw new StosEmptyException();
        public bool IsEmpty => items.Count == 0;
        public int Count => items.Count;
        public T[] ToArray() => items.ToArray();

        public void Clear() => items.Clear();
    }
}