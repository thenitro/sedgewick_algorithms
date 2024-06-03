using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_30_ReverseLinkedList
    {
        [Test]
        public void Smoke()
        {
            var node = new LinkedListNode<int>(1,
                new LinkedListNode<int>(2, new LinkedListNode<int>(3, new LinkedListNode<int>(4))));

            var result = new E_1_3_30_ReverseLinkedList().Solution(node);
            
            Assert.AreEqual(4, result.Value);
            Assert.AreEqual(3, result.Next.Value);
            Assert.AreEqual(2, result.Next.Next.Value);
            Assert.AreEqual(1, result.Next.Next.Next.Value);
            Assert.Null(result.Next.Next.Next.Next);
        }
        
        [Test]
        public void Two()
        {
            var node = new LinkedListNode<int>(1,
                new LinkedListNode<int>(2));

            var result = new E_1_3_30_ReverseLinkedList().Solution(node);
            
            Assert.AreEqual(2, result.Value);
            Assert.AreEqual(1, result.Next.Value);
            Assert.Null(result.Next.Next);
        }
        
        [Test]
        public void One()
        {
            var node = new LinkedListNode<int>(1);

            var result = new E_1_3_30_ReverseLinkedList().Solution(node);
            
            Assert.AreEqual(1, result.Value);
            Assert.Null(result.Next);
        }
    }
}