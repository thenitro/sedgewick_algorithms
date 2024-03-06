using System;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;

namespace Tests.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    [TestFixture]
    public class Test_E_1_1_39_RandomMatches
    {
        [Test]
        [TestCase(3)]
        public void SmokeTest(int trials)
        {
            var Ns = new[] { Math.Pow(10, 3), Math.Pow(10, 4), Math.Pow(10, 5), Math.Pow(10, 6) };

            foreach (int amountOfValues in Ns)
            {
                var amountOfAppears = 0;
                
                for (var trial = 0; trial <= trials; trial++)
                {
                    var randomA = GenerateRandomArray(amountOfValues);
                    var randomB = GenerateRandomArray(amountOfValues);
                    
                    amountOfAppears += E_1_1_39_RandomMatches.AppearsInBoth(randomA, randomB);
                }

                Console.WriteLine($"Values amount {amountOfValues}, average amount of appears {1.0 * amountOfAppears / trials}");
            }
        }

        private int[] GenerateRandomArray(int amountOfValues)
        {
            var result = new int[amountOfValues];

            for (int i = 0; i < amountOfValues; i++)
            {
                result[i] = new Random().Next(999999);
            }
            
            return result;
        }
    }
}