using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_14_ResizingArrayQueue<T>
    {
        public int Count { get; private set; }
        
        private T[] _items = Array.Empty<T>();
        private int _current = 0;
        
        public void Enqueue(T item)
        {
            ResizeIfNeeded();
            
            _items[_current + Count++] = item;
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                Clean();
                
                return default;
            }

            Count--;
            return _items[_current++];
        }

        private void Clean()
        {
            _items = Array.Empty<T>();

            Count = 0;
            _current = 0;
        }
        
        private void ResizeIfNeeded()
        {
            if (_current + Count < _items.Length) return;
            
            var newItems = new T[Count == 0 ? 2 : Count * 2];

            for (var i = 0; i < Count; i++)
            {
                newItems[i] = _items[_current + i];
            }

            _current = 0;
            _items = newItems;
        }
    }
}