using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_48_TwoStacksWithDeque
    {
        [Test]
        public void Smoke()
        {
            var twoStacks = new E_1_3_48_TwoStacksWithDeque<int>();
            twoStacks.FirstPush(1);
            twoStacks.FirstPush(2);
            twoStacks.FirstPush(3);
            twoStacks.SecondPush(4);
            twoStacks.SecondPush(5);
            twoStacks.SecondPush(6);
            twoStacks.SecondPush(7);
            Assert.AreEqual(3, twoStacks.FirstCount);
            Assert.AreEqual(4, twoStacks.SecondCount);
            Assert.AreEqual(3, twoStacks.FirstPop());
            Assert.AreEqual(2, twoStacks.FirstPop());
            Assert.AreEqual(1, twoStacks.FirstPop());
            Assert.AreEqual(0, twoStacks.FirstPop());
            Assert.AreEqual(7, twoStacks.SecondPop());
            Assert.AreEqual(6, twoStacks.SecondPop());
            Assert.AreEqual(5, twoStacks.SecondPop());
            Assert.AreEqual(4, twoStacks.SecondPop());
            Assert.AreEqual(0, twoStacks.SecondPop());
        }
    }
}