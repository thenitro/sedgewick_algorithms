using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;

namespace Tests.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    [TestFixture]
    public class Test_E_1_1_19_Fibonacci
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(0, new E_1_1_19_Fibonacci().Fibonacci(0));
            Assert.AreEqual(1, new E_1_1_19_Fibonacci().Fibonacci(1));
            Assert.AreEqual(1, new E_1_1_19_Fibonacci().Fibonacci(2));
            Assert.AreEqual(2, new E_1_1_19_Fibonacci().Fibonacci(3));
        }
    }
}