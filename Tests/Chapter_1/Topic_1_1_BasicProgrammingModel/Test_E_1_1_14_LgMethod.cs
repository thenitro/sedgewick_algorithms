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
                double.NegativeInfinity, 
                new E_1_1_14_LgMethod().Lg(0));
        }

        [Test]
        public void RationalNumbers()
        {
            Assert.AreEqual(
                0, 
                new E_1_1_14_LgMethod().Lg(0));
        }
    }
}