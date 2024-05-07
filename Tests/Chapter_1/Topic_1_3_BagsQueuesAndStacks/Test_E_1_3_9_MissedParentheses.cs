using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_9_MissedParentheses
    {
        [Test]
        public void OneExpressionCase()
        {
            Assert.AreEqual("(1+2)", new E_1_3_9_MissedParentheses().Solution("1+2)"));
            Assert.AreEqual("((1+2)*(3-4))", new E_1_3_9_MissedParentheses().Solution("1+2)*3-4))"));
            Assert.AreEqual("((1+2)*((3-4)*(5-6)))", new E_1_3_9_MissedParentheses().Solution("1+2)*3-4)*5-6)))"));
        }
    }
}