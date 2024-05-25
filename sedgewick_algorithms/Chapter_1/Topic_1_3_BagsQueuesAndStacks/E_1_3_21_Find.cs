namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_21_Find
    {
        public bool Solution(TLinkedList<string> list, string key)
        {
            var current = list.First;

            while (current != null)
            {
                if (current.Value == key)
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }
    }
}