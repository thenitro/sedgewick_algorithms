using System;
using System.Collections;
using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_39_RingBuffer<T> : IEnumerable<T>
    {
        public int Count { get; private set; } = 0;
        
        private readonly T[] _data;
        private int _firstIndex = 0;
        private bool _firstDequeue = true;
        
        public E_1_3_39_RingBuffer(int size)
        {
            _data = new T[size];
        }

        public void Enqueue(T value)
        {
            if (_firstIndex + Count == _data.Length)
            {
                if (_firstIndex == 0)
                {
                    throw new OutOfMemoryException("Buffer is full");
                    return;
                }
                else
                {
                    RearrangeElements();
                }
            }

            _data[_firstIndex + Count] = value;
            
            Count++;
        }

        public T Dequeue()
        {
            if (_firstIndex == _data.Length)
            {
                throw new ArgumentOutOfRangeException("Buffer is empty!");
                return default;
            }

            Count--;

            if (_firstDequeue)
            {
                _firstDequeue = false;
            }
            else
            {
                _firstIndex++;
            }
            
            return _data[_firstIndex];
        }

        private void RearrangeElements()
        {
            for (var i = 0; i < _data.Length; i++)
            {
                if (i > _firstIndex)
                {
                    _data[i] = default;
                }
                else
                {
                    _data[i] = _data[i + _firstIndex];
                }
            }

            _firstDequeue = true;
            _firstIndex = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var index = _firstIndex;
            
            while (true)
            {
                yield return _data[index];

                index++;
                
                if (index == Count - _firstIndex)
                {
                    index = _firstIndex;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}