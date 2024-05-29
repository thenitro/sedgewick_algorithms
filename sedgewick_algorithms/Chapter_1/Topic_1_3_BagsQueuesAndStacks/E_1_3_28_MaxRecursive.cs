using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_28_MaxRecursive
    {
        public uint Solution(Node<uint> currentNode, uint max = 0)
        {
            if (currentNode == null) return max;

            return Solution(currentNode.Next, Math.Max(max, currentNode.Value));
        }
    }
}