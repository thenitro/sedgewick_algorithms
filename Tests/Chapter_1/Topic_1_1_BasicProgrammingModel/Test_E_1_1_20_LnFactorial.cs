using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;

namespace Tests.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    [TestFixture]
    public class Test_E_1_1_20_LnFactorial
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(0, new E_1_1_20_LnFactorial().Factorial(1));
            Assert.AreEqual(4.7874917427820458d, new E_1_1_20_LnFactorial().Factorial(5));
        }
    }
}