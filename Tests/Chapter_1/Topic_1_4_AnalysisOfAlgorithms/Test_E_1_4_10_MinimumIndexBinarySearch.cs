using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_4_AnalysisOfAlgorithms;

namespace Tests.Chapter_1.Topic_1_4_AnalysisOfAlgorithms
{
    [TestFixture]
    public class Test_E_1_4_10_MinimumIndexBinarySearch
    {
        [Test]
        public void Smoke()
        {
            var testCase = new [] { 1, 1, 1, 2, 2, 2, 3, 4, 4, 4, 5, 6, 6 };
            Assert.AreEqual(0, new E_1_4_10_MinimumIndexBinarySearch().Find(testCase, 1));
            Assert.AreEqual(3, new E_1_4_10_MinimumIndexBinarySearch().Find(testCase, 2));
            Assert.AreEqual(6, new E_1_4_10_MinimumIndexBinarySearch().Find(testCase, 3));
            Assert.AreEqual(7, new E_1_4_10_MinimumIndexBinarySearch().Find(testCase, 4));
            Assert.AreEqual(10, new E_1_4_10_MinimumIndexBinarySearch().Find(testCase, 5));
            Assert.AreEqual(11, new E_1_4_10_MinimumIndexBinarySearch().Find(testCase, 6));
        }
    }
}