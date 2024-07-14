using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_42_CopyStack
    {
        public Stack<int> Solution(Stack<int> stack)
        {
            var helper = new Stack<int>();

            while (stack.Count > 0)
            {
                helper.Push(stack.Pop());
            }

            var result = new Stack<int>();

            while (helper.Count > 0)
            {
                var item = helper.Pop();
                result.Push(item);
                stack.Push(item);
            }

            return result;
        }
    }
}