using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_CircularLinkedList
    {
        [Test]
        public void SmokeTest()
        {
            var list = new CircularLinkedList<int>(new LinkedListNode<int>(1));
            list.Add(new LinkedListNode<int>(2));
            list.Add(new LinkedListNode<int>(3));
            
            Assert.AreEqual(1, list.First.Value);
            Assert.AreEqual(2, list.First.Next.Value);
            Assert.AreEqual(3, list.First.Next.Next.Value);
            Assert.AreEqual(1, list.First.Next.Next.Next.Value);

            Assert.AreEqual(1, list.PopFirst());
            Assert.AreEqual(2, list.First.Value);
            Assert.AreEqual(2, list.PopFirst());
            Assert.AreEqual(3, list.First.Value);
            Assert.AreEqual(3, list.PopFirst());
            Assert.Null(list.First);
        }
    }
}