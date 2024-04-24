using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_4_Parentheses
    {
        public bool IsValid(string stream)
        {
            var stack = new Stack<char>();

            foreach (var currentChar in stream)
            {
                if (stack.Count > 0 && IsValidChar(stack.Peek(), currentChar))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(currentChar);
                }
            }
            
            return stack.Count == 0;
        }

        private bool IsValidChar(char peek, char currentChar)
        {
            if (peek == '[' && currentChar == ']') return true;
            if (peek == '{' && currentChar == '}') return true;
            if (peek == '(' && currentChar == ')') return true;

            return false;
        }
    }
}