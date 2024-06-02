using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_20_DeleteKth
    {
        [Test]
        public void SmokeTest()
        {
            var list = new TLinkedList<int>(new LinkedListNode<int>(1, new LinkedListNode<int>(2, new LinkedListNode<int>(3))));
            
            new E_1_3_20_DeleteKth().Solution(list, 1);
            
            Assert.AreEqual(1, list.First.Value);
            Assert.AreEqual(3, list.First.Next.Value);
        }
        
        [Test]
        public void DeleteFirst()
        {
            var list = new TLinkedList<int>(new LinkedListNode<int>(1, new LinkedListNode<int>(2, new LinkedListNode<int>(3))));
            
            new E_1_3_20_DeleteKth().Solution(list, 0);
            
            Assert.AreEqual(2, list.First.Value);
            Assert.AreEqual(3, list.First.Next.Value);
        }
        
        [Test]
        public void DeleteLast()
        {
            var list = new TLinkedList<int>(new LinkedListNode<int>(1, new LinkedListNode<int>(2, new LinkedListNode<int>(3))));
            
            new E_1_3_20_DeleteKth().Solution(list, 2);
            
            Assert.AreEqual(1, list.First.Value);
            Assert.AreEqual(2, list.First.Next.Value);
            Assert.Null(list.First.Next.Next);
        }
    }
}