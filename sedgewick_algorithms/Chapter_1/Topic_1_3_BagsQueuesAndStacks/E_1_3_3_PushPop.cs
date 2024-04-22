using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_3_PushPop
    {
        public bool CanOccur(int[] sequence)
        {
            var testStack = new Queue<int>(sequence);
            var trackStack = new Stack<int>();

            var maxNumber = 0;
            
            while (testStack.Count > 0)
            {
                var testNumber = testStack.Dequeue();

                if (testNumber >= maxNumber)
                {
                    for (var i = maxNumber; i <= testNumber; i++)
                    {
                        trackStack.Push(i);
                    }

                    maxNumber = testNumber + 1;
                }

                var trackNumber = trackStack.Pop();

                if (testNumber != trackNumber)
                {
                    return false;
                }
            }

            return true;
        }
    }
}