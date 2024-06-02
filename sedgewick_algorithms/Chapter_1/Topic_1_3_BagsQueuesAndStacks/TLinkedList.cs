namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class TLinkedList<T>
    {
        public LinkedListNode<T> First { get; set; }

        public TLinkedList(LinkedListNode<T> first)
        {
            First = first;
        }
    }
}