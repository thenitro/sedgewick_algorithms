namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_30_ReverseLinkedList
    {
        public LinkedListNode<int> Solution(LinkedListNode<int> node)
        {
            if (node == null) return null;

            var current = node;
            LinkedListNode<int> prev = null;

            while (current != null)
            {
                var next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
    }
}