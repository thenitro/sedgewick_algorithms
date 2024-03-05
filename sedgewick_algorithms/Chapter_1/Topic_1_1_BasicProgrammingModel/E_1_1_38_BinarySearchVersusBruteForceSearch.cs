namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_38_BinarySearchVersusBruteForceSearch
    {
        public static int Rank(int key, int[] a)
        {
            for (var i = 0; i < a.Length; i++)
            {
                if (key == a[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}