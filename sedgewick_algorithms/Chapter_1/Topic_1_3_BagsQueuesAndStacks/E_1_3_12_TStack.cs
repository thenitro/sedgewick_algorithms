using System;
using System.Collections;
using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_12_TStack<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        
        private T[] _data = Array.Empty<T>();

        public void Push(T item)
        {
            if (IsFull())
            {
                _data = Allocate();
            }

            _data[Count++] = item;
        }

        private T[] Allocate()
        {
            var newData = new T[Count == 0 ? 1 : Count * 2];

            for (var i = 0; i < _data.Length; i++)
            {
                newData[i] = _data[i];
            }
            
            return newData;
        }

        public T Pop()
        {
            return _data[--Count];
        }

        public T Peek()
        {
            return _data[Count - 1];
        }

        private bool IsFull()
        {
            return _data.Length == Count;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            for (var i = Count - 1; i >= 0; i--)
            {
                yield return _data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public E_1_3_12_TStack<T> Copy()
        {
            var copy = new E_1_3_12_TStack<T>();

            for (var i = 0; i < Count; i++)
            {
                copy.Push(_data[i]);
            }
            
            return copy;
        }
    }
}