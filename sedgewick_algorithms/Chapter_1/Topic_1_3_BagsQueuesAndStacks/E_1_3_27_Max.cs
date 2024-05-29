using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_27_Max
    {
        public uint Solution(Node<uint> first)
        {
            var current = first;
            var max = (uint)0;

            while (current != null)
            {
                max = Math.Max(max, current.Value);
                current = current.Next;
            }

            return max;
        }
    }
}