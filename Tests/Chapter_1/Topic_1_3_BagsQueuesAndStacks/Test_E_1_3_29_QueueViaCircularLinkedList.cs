using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_29_QueueViaCircularLinkedList
    {
        [Test]
        public void Smoke()
        {
            var queue = new E_1_3_29_QueueViaCircularLinkedList<int>();
            Assert.Zero(queue.Count);
            queue.Enqueue(1);
            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(0, queue.Count);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.AreEqual(3, queue.Count);
            
            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
            Assert.AreEqual(3, queue.Dequeue());
            Assert.AreEqual(0, queue.Count);
        }
    }
}