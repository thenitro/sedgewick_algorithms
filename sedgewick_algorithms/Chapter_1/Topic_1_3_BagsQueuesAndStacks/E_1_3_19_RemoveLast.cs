namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_19_RemoveLast
    {
        public void Solution(TLinkedList<int> list)
        {
            var current = list.First;
            var prev = list.First;
            
            while (current?.Next != null)
            {
                prev = current;
                current = current.Next;
            }
            
            if (prev == list.First)
            {
                list.First = null;
            }
            else
            {
                prev.Next = null;
            }
        }
    }
}