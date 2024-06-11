using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_33_Deque
    {
        [Test]
        public void SmokeResizingArray()
        {
            Smoke(new E_1_3_33_Deque_ResizingArra<int>());
        }
        
        [Test]
        public void SmokeDoublyLinkedList()
        {
            Smoke(new E_1_3_33_Deque_DoublyLinkedList<int>());
        }
        
        private void Smoke(IDeque<int> deque)
        {
            Assert.True(deque.IsEmpty);
            Assert.Zero(deque.Count);
            
            deque.PushLeft(2);
            deque.PushLeft(1);
            deque.PushRight(3);
            deque.PushRight(4);
            
            Assert.AreEqual(4, deque.PopRight());
            Assert.AreEqual(3, deque.PopRight());
            Assert.AreEqual(1, deque.PopLeft());
            Assert.AreEqual(2, deque.PopLeft());
            Assert.True(deque.IsEmpty);
            Assert.Zero(deque.Count);
            
            deque.PushRight(3);
            deque.PushRight(4);
            deque.PushLeft(2);
            deque.PushLeft(1);
            
            Assert.AreEqual(1, deque.PopLeft());
            Assert.AreEqual(2, deque.PopLeft());
            Assert.AreEqual(4, deque.PopRight());
            Assert.AreEqual(3, deque.PopRight());
            Assert.True(deque.IsEmpty);
            Assert.Zero(deque.Count);
        }
    }
}