namespace sedgewick_algorithms.Chapter_1.Topic_1_4_AnalysisOfAlgorithms
{
    public class E_1_4_10_MinimumIndexBinarySearch
    {
        public int Find(int[] testCase, int x)
        {
            var lo = 0;
            var hi = testCase.Length - 1;

            while (lo <= hi)
            {
                var mid = (hi - lo) / 2 + lo;

                if (x < testCase[mid])
                {
                    hi = mid - 1;
                } 
                else if (x > testCase[mid])
                {
                    lo = mid + 1;
                }
                else
                {
                    hi = mid - 1;
                }
            }

            return (lo < testCase.Length && testCase[lo] == x) ? lo : -1;
        }
    }
}