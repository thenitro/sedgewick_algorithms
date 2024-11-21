using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_4_AnalysisOfAlgorithms;

namespace Tests.Chapter_1.Topic_1_4_AnalysisOfAlgorithms
{
    [TestFixture]
    public class Test_E_1_4_11_StaticSetOfInts
    {
        [Test]
        public void Smoke()
        {
            var testCase = new [] { 0, 1, 2, 3, 3, 3, 3, 4, 5, 5, 5, 6, 7, 9 };
            var set = new E_1_4_11_StaticSetOfInts(testCase);
            
            Assert.True(set.Contains(0));
            Assert.AreEqual(1, set.HowMany(0));
            
            Assert.True(set.Contains(1));
            Assert.AreEqual(1, set.HowMany(1));
            
            Assert.True(set.Contains(2));
            Assert.AreEqual(1, set.HowMany(2));
            
            Assert.True(set.Contains(3));
            Assert.AreEqual(4, set.HowMany(3));
            
            Assert.True(set.Contains(4));
            Assert.AreEqual(1, set.HowMany(4));
            
            Assert.True(set.Contains(5));
            Assert.AreEqual(3, set.HowMany(5));
            
            Assert.True(set.Contains(6));
            Assert.AreEqual(1, set.HowMany(6));
            
            Assert.True(set.Contains(7));
            Assert.AreEqual(1, set.HowMany(7));
            
            Assert.False(set.Contains(8));
            Assert.AreEqual(0, set.HowMany(8));
            
            Assert.True(set.Contains(9));
            Assert.AreEqual(1, set.HowMany(9));
        }
    }
}