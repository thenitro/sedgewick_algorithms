namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_38_DeleteKthElementQueue_LinkedList<T> : IGeneralizedQueue<T>
    {
        private int _totalCount;
        private int _count;

        private LinkedListNode<QueuePair<T>> _head;
        private LinkedListNode<QueuePair<T>> _last;

        public bool IsEmpty() => _count == 0;

        public void Insert(T item)
        {
            var node = new LinkedListNode<QueuePair<T>>(new QueuePair<T>(_totalCount++, item));
            
            if (_head == null)
            {
                _head = node;
            }

            if (_last != null)
            {
                _last.Next = node;
            }
            
            _last = node;
            
            _count++;
        }

        public T Delete(int index)
        {
            var current = _head;
            LinkedListNode<QueuePair<T>> prev = null;
            
            while (current != null)
            {
                if (current.Value.Index == index)
                {
                    if (prev == null)
                    {
                        if (current.HasNext)
                        {
                            _head = current.Next;
                        }
                        else
                        {
                            _head = null;
                            _last = null;
                        }
                    }
                    else
                    {
                        if (current.HasNext)
                        {
                            prev.Next = current.Next;
                        }
                        else
                        {
                            prev.Next = null;
                            _last = prev;
                        }
                    }

                    _count--;
                    
                    return current.Value.Value;
                }

                prev = current;
                current = current.Next;
            }

            return default;
        }

        private class QueuePair<T>
        {
            public int Index { get; }
            public T Value { get; }

            public QueuePair(int index, T value)
            {
                Index = index;
                Value = value;
            }
        }
    }
}