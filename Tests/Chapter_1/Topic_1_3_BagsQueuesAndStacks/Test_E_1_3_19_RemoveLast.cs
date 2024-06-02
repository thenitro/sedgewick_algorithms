using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_19_RemoveLast
    {
        [Test]
        public void SmokeTest()
        {
            var list = new TLinkedList<int>(new LinkedListNode<int>(1, new LinkedListNode<int>(2, new LinkedListNode<int>(3))));

            new E_1_3_19_RemoveLast().Solution(list);

            var count = 0;
            var current = list.First;

            while (current != null)
            {
                current = current.Next;
                count++;
            }
            
            Assert.AreEqual(2, count);
        }
        
        [Test]
        public void OneNodeTest()
        {
            var list = new TLinkedList<int>(new LinkedListNode<int>(1));

            new E_1_3_19_RemoveLast().Solution(list);

            var count = 0;
            var current = list.First;

            while (current != null)
            {
                current = current.Next;
                count++;
            }
            
            Assert.AreEqual(0, count);
        }
    }
}