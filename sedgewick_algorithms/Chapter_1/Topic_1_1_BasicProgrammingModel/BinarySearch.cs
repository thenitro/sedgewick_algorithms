using sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction;

namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class BinarySearch
    {
        public static int Rank(int key, int[] a, Counter counter = null)
        {
            var lo = 0;
            var hi = a.Length - 1;

            while (lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;
                
                counter?.Increment();
                
                if (key < a[mid])
                {
                    hi = mid - 1;
                }
                else if (key > a[mid])
                {
                    lo = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}