using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;

namespace Tests.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    [TestFixture]
    public class Test_E_1_1_14_LgMethod
    {
        [Test]
        public void Zero()
        {
            Assert.AreEqual(
                int.MinValue, 
                new E_1_1_14_LgMethod().Lg(0));
        }

        [Test]
        public void RationalNumbers()
        {
            Assert.AreEqual(
                0, 
                new E_1_1_14_LgMethod().Lg(1));
            
            Assert.AreEqual(
                1, 
                new E_1_1_14_LgMethod().Lg(2));
            
            Assert.AreEqual(
                2, 
                new E_1_1_14_LgMethod().Lg(4));
            
            Assert.AreEqual(
                5, 
                new E_1_1_14_LgMethod().Lg(32));
            
            Assert.AreEqual(
                8, 
                new E_1_1_14_LgMethod().Lg(256));
        }
    }
}