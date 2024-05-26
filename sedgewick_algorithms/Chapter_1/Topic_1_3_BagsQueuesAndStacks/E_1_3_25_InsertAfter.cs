namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_25_InsertAfter
    {
        public void Solution(Node<int> current, Node<int> nodeToInsert)
        {
            if (current == null) return;

            var next = current.Next;

            current.Next = nodeToInsert;
            nodeToInsert.Next = next;
        }
    }
}