namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_19_Fibonacci
    {
        public long Fibonacci(int N)
        {
            if (N == 0) return 0;
            if (N == 1) return 1;

            return Fibonacci(N - 1) + Fibonacci(N - 2);
        }
    }
}