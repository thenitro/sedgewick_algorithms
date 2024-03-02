using System;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;

namespace Tests.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    [TestFixture]
    public class Test_E_1_1_35_DiceSimulation
    {
        [Test]
        public void RandomMeetsDistribution()
        {
            var distribution = new E_1_1_35_DiceSimulation().GetDistribution();
            
            const int decimalPlaces = 3;
            var epsilon = 1.0 / (Math.Pow(10, decimalPlaces));
            
            const int N = 300000;
            var simulation = MakeSimulation(N);
            
            for (int i = 0; i < distribution.Length; i++)
            {
                Assert.True(IsEqual(distribution[i], simulation[i], epsilon));
            }
        }

        private double[] MakeSimulation(int N)
        {
            const int sides = 6;
            var result = new double[2 * sides + 1];
            var throws = N * 1.0;
            
            while (N > 0)
            {
                var a = new Random().Next(1, 7);
                var b = new Random().Next(1, 7);

                var sum = a + b;

                result[sum] += 1.0;
                
                N--;
            }

            for (var i = 0; i < result.Length; i++)
            {
                if (result[i] == 0.0)
                {
                    continue;
                }
                
                result[i] /= throws;
            }
            
            return result;
        }

        private bool IsEqual(double a, double b, double epsilon)
        {
            return Math.Abs(a - b) <= epsilon;
        }
    }
}