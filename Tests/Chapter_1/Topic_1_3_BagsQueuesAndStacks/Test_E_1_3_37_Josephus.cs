using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_37_Josephus
    {
        [Test]
        public void Smoke()
        {
            var josephus = new E_1_3_37_Josephus().Solution(7, 2);
            
            Assert.AreEqual(1, josephus.Dequeue());
            Assert.AreEqual(3, josephus.Dequeue());
            Assert.AreEqual(5, josephus.Dequeue());
            Assert.AreEqual(0, josephus.Dequeue());
            Assert.AreEqual(4, josephus.Dequeue());
            Assert.AreEqual(2, josephus.Dequeue());
            Assert.AreEqual(6, josephus.Dequeue());
        }
    }
}