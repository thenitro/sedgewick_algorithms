using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;
using sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction;

namespace Tests.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    [TestFixture]
    public class Test_E_1_1_38_BinarySearchVersusBruteForceSearch
    {
        /**
         * results of benchmark on my M1 quite remarkable
         * Brute force 853078.512
         * Binary search 368.921
         */
        [Test]
        public void CheckTime()
        {
            var whitelistItems = File.ReadLines("./data/largeAllowlist.txt").Select(s => int.Parse(s)).ToArray();
            var allItems = File.ReadLines("./data/largeText.txt").Select(s => int.Parse(s)).ToArray();

            Benchmark(allItems, whitelistItems, E_1_1_38_BinarySearchVersusBruteForceSearch.Rank, "Brute force {0}");

            Array.Sort(allItems);
            Benchmark(allItems, whitelistItems, RankWrapper, "Binary search {0}");
        }

        private int RankWrapper(int key, int[] items) => BinarySearch.Rank(key, items);

        private void Benchmark(int[] allItems, int[] whiteListItems, Func<int, int[], int> rankFunction, string messageFormat)
        {
            var startTime = DateTime.Now;
            
            foreach (var whitelistItem in whiteListItems)
            {
                rankFunction(whitelistItem, allItems);
            }

            Console.WriteLine(messageFormat, (DateTime.Now - startTime).TotalMilliseconds);
        }
    }
}