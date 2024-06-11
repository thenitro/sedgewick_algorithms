using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_33_Deque_ResizingArra<T> : IDeque<T>
    {
        public bool IsEmpty => Count == 0;
        public int Count { get; private set; }

        private T[] _data;
        
        public void PushLeft(T item)
        {
            Count++;

            if (_data == null)
            {
                _data = new[] { item };
            }
            else
            {
                var newData = new T[(_data.Length <= Count ? Count * 2 : Count) + 1];
                newData[0] = item;
                
                for (var i = 0; i < Count - 1; i++)
                {
                    newData[i + 1] = _data[i];
                }

                _data = newData;
            }
        }

        public void PushRight(T item)
        {
            Count++;

            if (_data == null)
            {
                _data = new[] { item };
            }
            else
            {
                if (_data.Length == Count - 1)
                {
                    var newData = new T[Count * 2];

                    for (var i = 0; i < _data.Length; i++)
                    {
                        newData[i] = _data[i];
                    }
                    
                    _data = newData;
                }
                
                _data[Count - 1] = item;
            }
        }

        public T PopLeft()
        {
            if (IsEmpty) return default;

            Count--;
            
            var result = _data[0];

            var newData = new T[_data.Length];

            for (var i = 1; i < _data.Length; i++)
            {
                newData[i - 1] = _data[i];
            }

            _data = newData;
            
            return result;
        }

        public T PopRight()
        {
            if (IsEmpty) return default;
            Count--;
            return _data[Count];
        }
    }
}