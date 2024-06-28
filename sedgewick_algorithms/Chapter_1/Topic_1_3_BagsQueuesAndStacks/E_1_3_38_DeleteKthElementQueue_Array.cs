using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_38_DeleteKthElementQueue_Array<T> : IGeneralizedQueue<T>
    {
        private T[] _data = Array.Empty<T>();
        private int _count = 0;
        private int _totalCount = 0;

        public bool IsEmpty() => _count == 0;

        public void Insert(T item)
        {
            if (_data.Length == _count)
            {
                ResizeArray();
            }

            _data[_totalCount++] = item;
            _count++;
        }

        public T Delete(int index)
        {
            var item = _data[index];
            
            _data[index] = default;
            _count--;

            return item;
        }
        
        private void ResizeArray()
        {
            var newData = new T[_count == 0 ? 1 : _count * 2];

            for (var i = 0; i < _count; i++)
            {
                newData[i] = _data[i];
            }

            _data = newData;
        }
    }
}