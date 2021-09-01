namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_15_Histogram
    {
        public int[] Histogram(int[] array, int M)
        {
            var result = new int[M];

            foreach (var i in array)
            {
                if (i < M)
                {
                    result[i]++;
                }
            }

            return result;
        }
    }
}