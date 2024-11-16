using System;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_4_AnalysisOfAlgorithms;

namespace Tests.Chapter_1.Topic_1_4_AnalysisOfAlgorithms
{
    [TestFixture]
    public class Test_E_1_4_8_EqualPairs
    {
        [Test]
        public void BadCase()
        {
            Assert.AreEqual(0, new E_1_4_8_EqualPairs().Test(Array.Empty<int>()));
        }

        [Test]
        public void Smoke()
        {
            var input = new[] { 1, 2, 2, 1, 0, 3, 5, 4, 7, 2 };
            Assert.AreEqual(2, new E_1_4_8_EqualPairs().Test(input));
        }
    }
}