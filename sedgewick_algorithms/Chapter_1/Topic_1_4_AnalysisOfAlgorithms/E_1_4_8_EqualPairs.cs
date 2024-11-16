using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_4_AnalysisOfAlgorithms
{
    public class E_1_4_8_EqualPairs
    {
        public int Test(int[] array)
        {
            if (array.Length < 2) return 0;
            
            Array.Sort(array);
            
            var N = array.Length;
            var count = 0;
            
            for (var i = 0; i < N - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                    i++;
                }
            }

            return count;
        }
    }
}