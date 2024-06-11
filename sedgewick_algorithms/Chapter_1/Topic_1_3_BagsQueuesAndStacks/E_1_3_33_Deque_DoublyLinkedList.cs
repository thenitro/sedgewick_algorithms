namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_33_Deque_DoublyLinkedList<T> : IDeque<T>
    {
        public bool IsEmpty => Count == 0;
        public int Count { get; private set; }

        private DoubleNode<T> _first;
        private DoubleNode<T> _last;
        
        public void PushLeft(T item)
        {
            Count++;
            
            var node = new DoubleNode<T>(item);
            
            if (_first == null)
            {
                _first = node;
            }
            else
            {
                node.Next = _first;
                _first.Prev = node;

                _first = node;
            }

            if (_last == null)
            {
                _last = node;
            }
        }

        public void PushRight(T item)
        {
            Count++;
            
            var node = new DoubleNode<T>(item);

            if (_first == null)
            {
                _first = node;
            }

            if (_last == null)
            {
                _last = node;
            }
            else
            {
                _last.Next = node;
                node.Prev = _last;

                _last = node;
            }
        }

        public T PopLeft()
        {
            if (IsEmpty) return default;

            Count--;

            var result = _first;

            _first = _first.Next;
            if (_first == null)
            {
                _first.Prev = null;
                _last = null;
            }
            
            return result.Value;
        }

        public T PopRight()
        {
            if (IsEmpty) return default;

            Count--;

            var result = _last;

            _last = _last.Prev;
            if (_last == null)
            {
                _last.Next = null;
                _first = null;
            }

            return result.Value;
        }
    }
}