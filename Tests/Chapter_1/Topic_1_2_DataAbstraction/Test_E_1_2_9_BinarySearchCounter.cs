using System;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;
using sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction;

namespace Tests.Chapter_1.Topic_1_2_DataAbstraction
{
    [TestFixture]
    public class Test_E_1_2_9_BinarySearchCounter
    {
        [Test]
        [TestCase(10000, 99)]
        public void SmokeTest(int N, int x)
        {
            var randomItems = new int[N];
            for (var i = 0; i < N; i++)
            {
                randomItems[i] = new Random().Next(0, 100);
            }
            
            Array.Sort(randomItems);

            var counter = new Counter("Binary search");

            BinarySearch.Rank(x, randomItems, counter);

            Console.WriteLine(counter);
        }
    }
}