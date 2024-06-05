using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_31_DoubleNode
    {
        private DoubleNode<int> GetTestTarget()
        {
            var first = new DoubleNode<int>(1);
            var second = new DoubleNode<int>(2);
            var third = new DoubleNode<int>(3);
            var fourth = new DoubleNode<int>(4);

            first.Next = second;

            second.Prev = first;
            second.Next = third;

            third.Prev = second;
            third.Next = fourth;

            fourth.Prev = third;
            
            Assert.AreEqual(1, first.Value);
            Assert.AreEqual(2, first.Next.Value);
            Assert.AreEqual(3, first.Next.Next.Value);
            Assert.AreEqual(4, first.Next.Next.Next.Value);
            
            return first;
        }
        
        [Test]
        public void TestInsertAtStart()
        {
            var first = GetTestTarget();
            
            Assert.Null(first.Prev);
            
            E_1_3_31_DoubleNode.InsertAtStart(first.Next.Next, new DoubleNode<int>(5));
            
            Assert.NotNull(first.Prev);
            Assert.AreEqual(5, first.Prev.Value);
            Assert.AreEqual(1, first.Prev.Next.Value);
            Assert.AreEqual(1, first.Value);
            Assert.AreEqual(2, first.Next.Value);
            Assert.AreEqual(3, first.Next.Next.Value);
            Assert.AreEqual(4, first.Next.Next.Next.Value);
        }
        
        [Test]
        public void TestInsertAtEnd()
        {
            var first = GetTestTarget();
            
            Assert.Null(first.Next.Next.Next.Next);
            
            E_1_3_31_DoubleNode.InsertAtEnd(first.Next.Next, new DoubleNode<int>(5));
            
            Assert.AreEqual(1, first.Value);
            Assert.AreEqual(2, first.Next.Value);
            Assert.AreEqual(3, first.Next.Next.Value);
            Assert.AreEqual(4, first.Next.Next.Next.Value);
            Assert.NotNull(first.Next.Next.Next.Next);
            Assert.AreEqual(5, first.Next.Next.Next.Next.Value);
            Assert.AreEqual(4, first.Next.Next.Next.Next.Prev.Value);
        }
        
        [Test]
        public void TestInsertBefore()
        {
            var first = GetTestTarget();
            
            E_1_3_31_DoubleNode.InsertBefore(first.Next.Next, new DoubleNode<int>(5));
            
            Assert.AreEqual(1, first.Value);
            Assert.AreEqual(2, first.Next.Value);
            Assert.AreEqual(5, first.Next.Next.Value);
            Assert.AreEqual(3, first.Next.Next.Next.Value);
            Assert.AreEqual(4, first.Next.Next.Next.Next.Value);
            Assert.AreEqual(3, first.Next.Next.Next.Next.Prev.Value);
            Assert.AreEqual(5, first.Next.Next.Next.Next.Prev.Prev.Value);
            Assert.AreEqual(2, first.Next.Next.Next.Next.Prev.Prev.Prev.Value);
            Assert.AreEqual(1, first.Next.Next.Next.Next.Prev.Prev.Prev.Prev.Value);
        }
        
        [Test]
        public void TestInsertAfter()
        {
            var first = GetTestTarget();
            
            E_1_3_31_DoubleNode.InsertAfter(first.Next.Next, new DoubleNode<int>(5));
            
            Assert.AreEqual(1, first.Value);
            Assert.AreEqual(2, first.Next.Value);
            Assert.AreEqual(3, first.Next.Next.Value);
            Assert.AreEqual(5, first.Next.Next.Next.Value);
            Assert.AreEqual(4, first.Next.Next.Next.Next.Value);
            Assert.AreEqual(5, first.Next.Next.Next.Next.Prev.Value);
            Assert.AreEqual(3, first.Next.Next.Next.Next.Prev.Prev.Value);
            Assert.AreEqual(2, first.Next.Next.Next.Next.Prev.Prev.Prev.Value);
            Assert.AreEqual(1, first.Next.Next.Next.Next.Prev.Prev.Prev.Prev.Value);
        }
        
        [Test]
        public void TestRemoveFromStart()
        {
            var first = GetTestTarget();
            var second = first.Next;
            
            E_1_3_31_DoubleNode.RemoveFromStart(first.Next.Next);

            Assert.Null(second.Prev);
            Assert.AreEqual(2, second.Value);
            Assert.Null(first.Next);
        }
        
        [Test]
        public void TestRemoveFromEnd()
        {
            var first = GetTestTarget();
            
            E_1_3_31_DoubleNode.RemoveFromEnd(first.Next.Next);
            
            Assert.AreEqual(1, first.Value);
            Assert.AreEqual(2, first.Next.Value);
            Assert.AreEqual(3, first.Next.Next.Value);
            Assert.Null(first.Next.Next.Next);
        }
        
        [Test]
        public void Remove()
        {
            var first = GetTestTarget();
            
            E_1_3_31_DoubleNode.Remove(first.Next.Next);
            
            Assert.AreEqual(1, first.Value);
            Assert.AreEqual(2, first.Next.Value);
            Assert.AreEqual(4, first.Next.Next.Value);
            Assert.Null(first.Next.Next.Next);
        }
    }
}