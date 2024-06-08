namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_31_DoubleNode
    {
        public static void InsertAtStart<T>(DoubleNode<T> current, DoubleNode<T> nodeToInsert)
        {
            var first = GetFirstNode(current);

            nodeToInsert.Next = first;
            first.Prev = nodeToInsert;
        }

        public static void InsertAtEnd<T>(DoubleNode<T> current, DoubleNode<T> nodeToInsert)
        {
            var last = GetLastNode(current);

            nodeToInsert.Prev = last;
            last.Next = nodeToInsert;
        }

        public static void InsertBefore<T>(DoubleNode<T> current, DoubleNode<T> nodeToInsert)
        {
            if (current.Prev != null)
            {
                current.Prev.Next = nodeToInsert;
            }
            
            nodeToInsert.Prev = current.Prev;
            current.Prev = nodeToInsert;

            nodeToInsert.Next = current;
        }

        public static void InsertAfter<T>(DoubleNode<T> current, DoubleNode<T> nodeToInsert)
        {
            if (current.Next != null)
            {
                current.Next.Prev = nodeToInsert;
            }

            nodeToInsert.Next = current.Next;
            current.Next = nodeToInsert;
            nodeToInsert.Prev = current;
        }

        public static void RemoveFromStart<T>(DoubleNode<T> current)
        {
            var first = GetFirstNode(current);
            var second = first?.Next;

            if (second == null) return;

            second.Prev = null;
            first.Next = null;
        }

        public static void RemoveFromEnd<T>(DoubleNode<T> current)
        {
            var last = GetLastNode(current);
            var secondFromEnd = last?.Prev;

            if (secondFromEnd == null) return;

            secondFromEnd.Next = null;
            last.Prev = null;
        }

        public static void Remove<T>(DoubleNode<T> current)
        {
            var prev = current.Prev;
            var next = current.Next;

            prev.Next = next;
            next.Prev = prev;

            current.Next = null;
            current.Prev = null;
        }
        
        private static DoubleNode<T> GetFirstNode<T>(DoubleNode<T> current)
        {
            var first = current;

            while (first.Prev != null)
            {
                first = first.Prev;
            }

            return first;
        }
        
        
        private static DoubleNode<T> GetLastNode<T>(DoubleNode<T> current)
        {
            var last = current;

            while (last.Next != null)
            {
                last = last.Next;
            }

            return last;
        }
    }
}