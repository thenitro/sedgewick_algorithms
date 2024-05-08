using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_10_InfixToPostfix
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual("3 4 +", new E_1_3_10_InfixToPostfix().Solution("(3+4)"));
            Assert.AreEqual("3 4 + 5 6 + *", new E_1_3_10_InfixToPostfix().Solution("((3+4)*(5+6))"));
        }
    }
}