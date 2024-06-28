using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_38_DeleteKthElementQueue
    {
        [Test]
        public void SmokeArrayImplementation()
        {
            var amount = 10;
            var queue = new E_1_3_38_DeleteKthElementQueue_Array<int>();
            
            Smoke(queue, amount);
        }
        
        [Test]
        public void SmokeLinkedListImplementation()
        {
            var amount = 10;
            var queue = new E_1_3_38_DeleteKthElementQueue_LinkedList<int>();
            
            Smoke(queue, amount);
        }

        private void Smoke(IGeneralizedQueue<int> queue, int amount)
        {
            Assert.True(queue.IsEmpty());
            
            for (var i = 0; i < amount; i++)
            {
                queue.Insert(i);
            }
            
            Assert.AreEqual(5, queue.Delete(5));
            Assert.AreEqual(9, queue.Delete(9));
            Assert.AreEqual(0, queue.Delete(0));
            Assert.AreEqual(8, queue.Delete(8));
            Assert.AreEqual(1, queue.Delete(1));
            Assert.AreEqual(7, queue.Delete(7));
            Assert.AreEqual(2, queue.Delete(2));
            Assert.AreEqual(6, queue.Delete(6));
            Assert.AreEqual(3, queue.Delete(3));
            Assert.AreEqual(4, queue.Delete(4));
            Assert.True(queue.IsEmpty());
        }
    }
}