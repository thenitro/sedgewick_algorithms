using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_25_InsertAfter
    {
        [Test]
        public void TestNull()
        {
            new E_1_3_25_InsertAfter().Solution(null, new Node<int>(0));
        }

        [Test]
        public void Smoke()
        {
            var node1 = new Node<int>(1);
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);

            node1.Next = node3;
            
            new E_1_3_25_InsertAfter().Solution(node1, node2);
            
            Assert.AreEqual(node2, node1.Next);
            Assert.AreEqual(node3, node1.Next.Next);
        }
    }
}