using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_32_Steque
    {
        [Test]
        public void SmokePushFirst()
        {
            var steque = new E_1_3_32_Steque<int>();
            Assert.Zero(steque.Pop());
            steque.Push(2);
            steque.Push(3);
            steque.Enqueue(1);
            Assert.AreEqual(3, steque.Pop());
            Assert.AreEqual(2, steque.Pop());
            Assert.AreEqual(1, steque.Pop());
        }
        
        [Test]
        public void SmokeEnqueueFirst()
        {
            var steque = new E_1_3_32_Steque<int>();
            Assert.Zero(steque.Pop());
            steque.Enqueue(1);
            steque.Push(2);
            steque.Push(3);
            Assert.AreEqual(3, steque.Pop());
            Assert.AreEqual(2, steque.Pop());
            Assert.AreEqual(1, steque.Pop());
        }
    }
}