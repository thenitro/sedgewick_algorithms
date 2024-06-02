using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_28_MaxRecursive
    {
        public uint Solution(LinkedListNode<uint> currentLinkedListNode, uint max = 0)
        {
            if (currentLinkedListNode == null) return max;

            return Solution(currentLinkedListNode.Next, Math.Max(max, currentLinkedListNode.Value));
        }
    }
}