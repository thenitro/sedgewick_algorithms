namespace sedgewick_algorithms.Chapter_1.Topic_1_4_AnalysisOfAlgorithms
{
    public class E_1_4_12_MergeTwoSortedArrays
    {
        public int[] Merge(int[] a, int[] b)
        {
            var result = new int[a.Length + b.Length];

            var indexA = 0;
            var indexB = 0;

            var count = 0;

            while (count < result.Length)
            {
                var aInRange = indexA < a.Length;
                var bInRange = indexB < b.Length;

                var currentElement = 0;

                if (aInRange && bInRange)
                {
                    if (a[indexA] > b[indexB])
                    {
                        currentElement = b[indexB];
                        indexB++;
                    }
                    else
                    {
                        currentElement = a[indexA];
                        indexA++;
                    }
                } else if (aInRange)
                {
                    currentElement = a[indexA];
                    indexA++;
                } else if (bInRange)
                {
                    currentElement = b[indexB];
                    indexB++;
                }

                result[count] = currentElement;
                count++;
            }
            
            return result;
        }
    }
}