using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_11_EvaluatePostfix
    {
        public double Evaluate(string input)
        {
            var splitInput = input.Split(' ');
            var stack = new Stack<double>();

            foreach (var s in splitInput)
            {
                switch (s)
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    {
                        var a = stack.Pop();
                        var b = stack.Pop();
                        var result = Calculate(a, b, s);
                        
                        stack.Push(result);
                        
                        break;
                    }

                    default:
                    {
                        stack.Push(int.Parse(s));
                        break;
                    }
                }
            }

            return stack.Pop();
        }

        private double Calculate(double a, double b, string operation)
        {
            if (operation == "+") return a + b;
            if (operation == "-") return a - b;
            if (operation == "*") return a * b;
            if (operation == "/") return a / b;

            return 0;
        }
    }
}