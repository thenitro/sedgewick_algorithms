using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_24_RemoveAfter
    {
        [Test]
        public void Smoke()
        {
            var node1 = new LinkedListNode<int>(1);
            var node2 = new LinkedListNode<int>(2);
            var node3 = new LinkedListNode<int>(3);

            node1.Next = node2;
            node2.Next = node3;
            
            new E_1_3_24_RemoveAfter().Solution(node1);
            Assert.AreEqual(3, node1.Next.Value);

            node1.Next = node2;
            node2.Next = node3;
            
            new E_1_3_24_RemoveAfter().Solution(node2);
            Assert.AreEqual(2, node1.Next.Value);
            Assert.Null(node2.Next);
            
            node1.Next = node2;
            node2.Next = node3;
            
            new E_1_3_24_RemoveAfter().Solution(node3);
        }
    }
}