using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;

namespace Tests.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    [TestFixture]
    public class Test_E_1_1_15_Histogram
    {
        [Test]
        public void SmokeTest()
        {
            var result = new E_1_1_15_Histogram().Histogram(
                new []{ 1, 1, 1, 1, 1, 2, 2, 2, 2, 2 }, 
                0);
            
            Assert.AreEqual(0, result.Length);
            
            var resultA = new E_1_1_15_Histogram().Histogram(
                new []{ 1, 1, 1, 1, 1, 2, 2, 2, 2, 2 }, 
                2);
            
            Assert.AreEqual(2, resultA.Length);
            Assert.AreEqual(0, resultA[0]);
            Assert.AreEqual(5, resultA[1]);
            
            var resultB = new E_1_1_15_Histogram().Histogram(
                new []{ 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2 }, 
                3);
            
            Assert.AreEqual(3, resultB.Length);
            Assert.AreEqual(5, resultB[0]);
            Assert.AreEqual(5, resultB[1]);
            Assert.AreEqual(5, resultB[2]);
        }
    }
}