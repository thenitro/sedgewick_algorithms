using System;
using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_45_StackGenerability
    {
        public bool IsUnderflow(List<char> operations)
        {
            var counter = 0;

            foreach (var character in operations)
            {
                if (character == '-')
                {
                    if (counter == 0) return true;
                    
                    counter--;
                }
                else
                {
                    counter++;
                }
            }
            
            return false;
        }

        public bool IsPermutation(List<int> sequence)
        {
            var stack = new Stack<int>();
            var next = 0;

            foreach (var i in sequence)
            {
                if (stack.Count == 0 || i > stack.Peek())
                {
                    for (; next < i; next++)
                    {
                        stack.Push(next);
                    }

                    next++;
                } 
                else if (stack.Count > 0 && stack.Peek() == i)
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}