using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_20_LnFactorial
    {
        public double Factorial(int n)
        {
            if (n == 1)
            {
                return 0;
            }

            return Factorial(n - 1) + Math.Log(n);
        }
    }
}