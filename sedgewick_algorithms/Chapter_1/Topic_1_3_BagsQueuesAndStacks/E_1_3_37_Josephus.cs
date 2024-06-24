using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_37_Josephus
    {
        public Queue<int> Solution(int N, int M)
        {
            var positions = new Queue<int>();
            var result = new Queue<int>();

            for (var i = 0; i < N; i++)
            {
                positions.Enqueue(i);
            }

            var counter = 0;
            
            while (positions.Count > 0)
            {
                var position = positions.Dequeue();
                counter++;

                if (counter % M == 0)
                {
                    result.Enqueue(position);
                }
                else
                {
                    positions.Enqueue(position);
                }
            }

            return result;
        }
    }
}