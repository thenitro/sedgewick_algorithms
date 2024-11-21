using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_4_AnalysisOfAlgorithms;

namespace Tests.Chapter_1.Topic_1_4_AnalysisOfAlgorithms
{
    [TestFixture]
    public class Test_E_1_4_12_MergeTwoSortedArrays
    {
        [Test]
        public void SmokeTest()
        {
            var a = new[] { 0, 2, 4, 6, 7, 8 };
            var b = new[] { 1, 3, 5, 9, 10 };

            var c = new E_1_4_12_MergeTwoSortedArrays().Merge(a, b);
            
            Assert.AreEqual(c.Length, a.Length + b.Length);
            
            for (var i = 0; i < 11; i++)
            {
                Assert.AreEqual(i, c[i]);
            }
        }
    }
}