using System;
using System.Collections;
using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class RandomQueue<T> : IEnumerable<T>
    {
        public bool IsEmpty => Count == 0;
        public int Count { get; private set; }

        private T[] _data;

        public void Enqueue(T item)
        {
            if (_data == null)
            {
                _data = new T[1];
            }

            if (_data.Length == Count)
            {
                var newData = new T[Count * 2];

                for (var i = 0; i < Count; i++)
                {
                    newData[i] = _data[i];
                }

                _data = newData;
            }

            _data[Count++] = item;
        }

        public T Dequeue()
        {
            var result = Sample();
            Count--;
            return result;
        }

        public T Sample()
        {
            return Sample(Count - 1);
        }

        private T Sample(int position)
        {
            var random = new Random().Next(position);
            (_data[position], _data[random]) = (_data[random], _data[position]);
            return _data[position];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = Count - 1; i >= 0; i--)
            {
                Sample(i);
            }

            for (var i = Count - 1; i >= 0; i--)
            {
                yield return _data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}