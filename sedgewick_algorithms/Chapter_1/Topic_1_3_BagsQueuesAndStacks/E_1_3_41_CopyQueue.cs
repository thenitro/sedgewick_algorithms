using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_41_CopyQueue
    {
        public Queue<int> Solution(Queue<int> queue)
        {
            var result = new Queue<int>();
            var originalCount = queue.Count;

            while (originalCount > 0)
            {
                var item = queue.Dequeue();
                
                result.Enqueue(item);
                queue.Enqueue(item);
                
                originalCount--;
            }

            return result;
        }
    }
}