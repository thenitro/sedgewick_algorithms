using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_14_ResizingArrayQueue
    {
        [Test]
        public void Smoke()
        {
            var queue = new E_1_3_14_ResizingArrayQueue<string>();
            Assert.AreEqual(0, queue.Count);
            queue.Enqueue("a");
            Assert.AreEqual(1, queue.Count);
            queue.Enqueue("b");
            queue.Enqueue("c");
            Assert.AreEqual(3, queue.Count);
            
            Assert.AreEqual("a", queue.Dequeue());
            Assert.AreEqual("b", queue.Dequeue());
            Assert.AreEqual("c", queue.Dequeue());
            Assert.AreEqual(0, queue.Count);
            Assert.AreEqual(null, queue.Dequeue());
            
            queue.Enqueue("a");
            queue.Enqueue("b");
            Assert.AreEqual("a", queue.Dequeue());
            Assert.AreEqual(1, queue.Count);
            queue.Enqueue("c");
            queue.Enqueue("d");
            Assert.AreEqual(3, queue.Count);
            Assert.AreEqual("b", queue.Dequeue());
            Assert.AreEqual(2, queue.Count);
        }
    }
}