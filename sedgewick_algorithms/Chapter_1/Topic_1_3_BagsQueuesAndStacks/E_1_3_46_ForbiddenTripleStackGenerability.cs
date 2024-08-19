using System;
using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_46_ForbiddenTripleStackGenerability
    {
        public bool CanGenerate(List<int> sequence)
        {
            Console.WriteLine("start");
            
            var stack = new Stack<int>();
            var result = new List<int>();

            foreach (var i in sequence)
            {
                while (stack.Count > 0 && stack.Peek() < i)
                {
                    result.Add(stack.Pop());
                }

                stack.Push(i);
            }
            
            result.AddRange(stack);

            Console.WriteLine(string.Join(",", result));

            return sequence.Count == result.Count && IsSorted(result);
        }

        private bool IsSorted(List<int> result) 
        {
            for (var i = 1; i < result.Count; i++)
            {
                if (result[i - 1] > result[i])
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}