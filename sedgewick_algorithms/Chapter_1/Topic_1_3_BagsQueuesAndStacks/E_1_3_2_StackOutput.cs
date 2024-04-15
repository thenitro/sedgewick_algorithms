using System.Collections.Generic;
using System.Text;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_2_StackOutput
    {
        public string Exec(string input)
        {
            var splitString = input.Split(' ');

            var stack = new Stack<string>();

            foreach (var s in splitString)
            {
                stack.Push(s);
            }
            
            var result = new StringBuilder();

            while (stack.Count > 0)
            {
                result.Append(stack.Pop());
                
                if (stack.Count > 0)
                {
                    result.Append(" ");
                }
            }
            
            return result.ToString();
        }
    }
}