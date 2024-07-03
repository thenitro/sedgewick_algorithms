using System.Collections;
using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_40_MoveToFront<T> : IEnumerable<T>
    {
        private Dictionary<T, DoubleNode<T>> _availableItems = new Dictionary<T, DoubleNode<T>>();
        private DoubleNode<T> _head;

        public T Front => _head == null ? default : _head.Value;
        
        public void Add(T item)
        {
            if (!_availableItems.TryGetValue(item, out DoubleNode<T> node))
            {
                node = new DoubleNode<T>(item);
                _availableItems.Add(item, node);
            }
            else
            {
                if (node.Prev != null)
                {
                    node.Prev.Next = node.Next;
                }

                if (node.Next != null)
                {
                    node.Next.Prev = node.Prev;
                }

                node.Next = null;
                node.Prev = null;
            }
            
            if (_head != null)
            {
                node.Next = _head;
                _head.Prev = node;
            }
            
            _head = node;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var next = _head;

            while (next != null)
            {
                yield return next.Value;
                
                next = next.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}