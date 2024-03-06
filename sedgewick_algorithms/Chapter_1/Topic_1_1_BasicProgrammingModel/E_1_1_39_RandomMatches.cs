using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_39_RandomMatches
    {
        public static int AppearsInBoth(int[] a, int[] b)
        {
            var founded = new HashSet<int>();

            foreach (var itemA in a)
            {
                Check(itemA, b, founded);
            }

            foreach (var itemB in b)
            { 
                Check(itemB, a, founded);
            }
            
            return founded.Count;
        }

        private static void Check(int item, int[] array, HashSet<int> founded)
        {
            if (founded.Contains(item))
            {
                return;
            }
            
            if (BinarySearch.Rank(item, array) > -1)
            {
                founded.Add(item);
            }
        }
    }
}