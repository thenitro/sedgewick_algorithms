using System.Collections.Generic;
using System.Text;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_10_InfixToPostfix
    {
        public string Solution(string input)
        {
            var operators = new Stack<char>();
            var operands = new Stack<string>();

            var sb = new StringBuilder();

            foreach (var currentChar in input)
            {
                switch (currentChar)
                {
                    case '(':
                        break;
                    case '*':
                    case '+':
                    case '-':
                    case '/':
                    {
                        operators.Push(currentChar);
                        break;
                    }
                    case ')':
                    {
                        var a = operands.Pop();
                        var b = operands.Pop();
                        var c = operators.Pop();

                        sb.Clear();
                        sb.AppendFormat("{1} {0} {2}", a, b, c);
                        
                        operands.Push(sb.ToString());
                        
                        break;
                    }
                    default:
                    {
                        operands.Push(currentChar.ToString());
                        break;
                    }
                }
            }
            
            return operands.Pop();
        } 
    }
}