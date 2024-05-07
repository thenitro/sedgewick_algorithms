using System.Collections.Generic;
using System.Text;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_9_MissedParentheses
    {
        public string Solution(string input)
        {
            var operators = new Stack<char>();
            var operands = new Stack<string>();

            var sb = new StringBuilder();

            foreach (var c in input)
            {
                switch (c)
                {
                    case '+':
                    case '-':
                    case '/':
                    case '*':
                    {
                        operators.Push(c);
                        break;
                    }
                    case ')':
                    {
                        var op = operators.Pop();
                        var valueA = operands.Pop();
                        var valueB = operands.Pop();

                        sb.Clear();
                        
                        sb.Append('(');
                        sb.Append(valueB);
                        sb.Append(op);
                        sb.Append(valueA);
                        sb.Append(')');
                        
                        operands.Push(sb.ToString());
                        
                        break;
                    }
                    default:
                    {
                        operands.Push(c.ToString());
                        break;
                    }
                }
            }

            return operands.Pop();
        }
    }
}