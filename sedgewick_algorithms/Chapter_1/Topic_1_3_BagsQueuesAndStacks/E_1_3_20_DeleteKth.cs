namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_20_DeleteKth
    {
        public void Solution(TLinkedList<int> list, int k)
        {
            if (k == 0)
            {
                list.First = list.First.Next;
                return;
            }
            
            var current = list.First;
            
            while (k > 1)
            {
                k--;
                current = current.Next;
            }
            
            current.Next = current.Next.Next;
        }
    }
}