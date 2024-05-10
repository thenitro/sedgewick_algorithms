using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_11_EvaluatePostfix
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(77, new E_1_3_11_EvaluatePostfix().Evaluate("3 4 + 5 6 + *"));
        }
    }
}