using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_4_Parentheses
    {
        [Test]
        public void Smoke()
        {
            Assert.False(new E_1_3_4_Parentheses().IsValid("["));
            Assert.True(new E_1_3_4_Parentheses().IsValid("[]"));
            Assert.True(new E_1_3_4_Parentheses().IsValid("[()]{}{[()()]()}"));
            Assert.False(new E_1_3_4_Parentheses().IsValid("[(])"));
        }
    }
}