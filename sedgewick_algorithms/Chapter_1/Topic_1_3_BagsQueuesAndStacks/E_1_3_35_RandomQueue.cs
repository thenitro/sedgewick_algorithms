using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_35_RandomQueue<T>
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
            var random = new Random().Next(Count - 1);
            (_data[Count - 1], _data[random]) = (_data[random], _data[Count - 1]);
            return _data[Count - 1];
        }
    }
}