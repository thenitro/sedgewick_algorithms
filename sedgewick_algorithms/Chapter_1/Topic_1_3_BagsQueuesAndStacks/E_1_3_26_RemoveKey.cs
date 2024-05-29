namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_26_RemoveKey
    {
        public void Solution(TLinkedList<string> target, string key)
        {
            if (target == null || target.First == null) return;
            
            var prev = target.First;
            var current = target.First;

            while (current != null)
            {
                if (target.First != current && current.Value == key)
                {
                    prev.Next = current.Next;
                }
                else
                {
                    prev = current;
                }
                
                current = current.Next;
            }

            if (target.First.Value == key)
            {
                target.First = target.First.Next;
            }
        }
    }
}