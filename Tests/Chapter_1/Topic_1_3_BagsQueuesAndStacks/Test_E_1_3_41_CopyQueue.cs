using System.Collections.Generic;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_41_CopyQueue
    {
        [Test]
        public void Smoke()
        {
            var amountOfElements = 5;
            var q = new Queue<int>();

            for (var i = 0; i < amountOfElements; i++)
            {
                q.Enqueue(i);
            }
            
            var r = new E_1_3_41_CopyQueue().Solution(q);
            
            Assert.False(q == r);
            for (var i = 0; i < amountOfElements; i++)
            {
                Assert.AreEqual(i, q.Peek());
                Assert.AreEqual(i, r.Peek());
                Assert.AreEqual(q.Dequeue(), r.Dequeue());
            }
        }
    }
}