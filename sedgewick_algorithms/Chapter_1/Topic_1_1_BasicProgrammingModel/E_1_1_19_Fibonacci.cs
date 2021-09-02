namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_19_Fibonacci
    {
        public long Fibonacci(int N)
        {
            if (N == 0) return 0;
            
            var table = new int[N + 1];
                table[1] = 1;

            for (var i = 2; i <= N; i++)
            {
                table[i] = table[i - 1] + table[i - 2];
            }

            return table[N];
        }
    }
}