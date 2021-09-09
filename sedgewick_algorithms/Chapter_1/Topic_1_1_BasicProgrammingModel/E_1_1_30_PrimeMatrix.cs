namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_30_PrimeMatrix
    {
        public bool[,] Build(int n)
        {
            var primes = new bool[n + 1];

            for (var i = 2; i < primes.Length; i++)
            {
                if (primes[i] == false)
                {
                    for (var j = i + i; j < primes.Length; j += i)
                    {
                        primes[j] = true;
                    }
                }
            }

            var result = new bool[n, n];

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (!primes[i] && !primes[j])
                    {
                        result[i, j] = true;
                    }
                }
            }

            return result;
        }
    }
}