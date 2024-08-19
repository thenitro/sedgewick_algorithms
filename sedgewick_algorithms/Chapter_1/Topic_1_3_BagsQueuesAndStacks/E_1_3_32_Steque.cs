namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_32_Steque<T>
    {
        private DoubleNode<T> _head;
        private DoubleNode<T> _tail;
        
        public void Push(T item)
        {
            var node = new DoubleNode<T>(item);
            
            if (_head == null)
            {
                _head = node;
            }

            if (_tail != null)
            {
                _tail.Next = node;
                node.Prev = _tail;
            }
            
            
            _tail = node;
        }

        public T Pop()
        {
            var node = _tail;
            var newTail = _tail?.Prev;

            if (node != null)
            {
                node.Prev = null;
                node.Next = null;
            }

            _tail = newTail;
            if (_tail != null)
            {
                _tail.Next = null;
            }
            
            return node == null ? default : node.Value;
        }

        public void Enqueue(T item)
        {
            var node = new DoubleNode<T>(item);

            if (_head != null)
            {
                _head.Prev = node;
                node.Next = _head;

            }

            if (_tail == null)
            {
                _tail = node;
            }
            
            _head = node;
        }

        public void Concat(E_1_3_32_Steque<T> other)
        {
            if (_tail == null)
            {
                _tail = other._head;
                _head = other._head;
            }
            else
            {
                _tail.Next = other._head;

                if (other._head != null)
                {
                    other._head.Prev = _tail;
                }

                _tail = other._tail;
            }
        }
    }
}