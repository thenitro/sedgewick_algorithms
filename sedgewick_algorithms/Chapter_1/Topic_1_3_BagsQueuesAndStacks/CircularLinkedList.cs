namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class CircularLinkedList<T>
    {
        public LinkedListNode<T> First { get; private set; }
        private LinkedListNode<T> _last;

        public CircularLinkedList(LinkedListNode<T> first)
        {
            First = first;
            _last = first;
        }

        public CircularLinkedList() { }

        public void Add(LinkedListNode<T> node)
        {
            if (First == null)
            {
                First = node;
                _last = node;
            }

            if (_last != null)
            {
                _last.Next = node;
            }
            
            node.Next = First;
            
            _last = node;
        }

        public T PopFirst()
        {
            var oldFirst = First;

            if (First == First?.Next)
            {
                First = null;
            }
            else
            {
                First = First?.Next;
            }

            if (_last != null)
            {
                _last.Next = First;
            }

            return oldFirst == null ? default : oldFirst.Value;
        }
    }
}