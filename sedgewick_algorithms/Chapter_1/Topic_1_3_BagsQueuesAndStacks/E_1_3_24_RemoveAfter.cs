namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_24_RemoveAfter
    {
        public void Solution(Node<int> current)
        {
            if (current == null) return;

            current.Next = current.Next?.Next;
        }
    }
}