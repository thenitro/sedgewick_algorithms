using System;
using System.Collections;
using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_34_RandomBag<T> : IEnumerable<T>
    {
        public bool IsEmpty => Count == 0;
        public int Count { get; private set; }

        private T[] _data = Array.Empty<T>();

        public void Add(T item)
        {
            if (_data.Length == Count)
            {
                var newData = new T[Count == 0 ? 1 : Count * 2];

                for (var i = 0; i < Count; i++)
                {
                    newData[i] = _data[i];
                }

                _data = newData;
            }

            if (Count > 1)
            {
                var randomIndex = new Random().Next(Count - 1);
                var tmp = _data[randomIndex];
            
                _data[Count++] = tmp;
                _data[randomIndex] = item;
            }
            else
            {
                _data[Count++] = item;
            }
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < Count; i++)
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