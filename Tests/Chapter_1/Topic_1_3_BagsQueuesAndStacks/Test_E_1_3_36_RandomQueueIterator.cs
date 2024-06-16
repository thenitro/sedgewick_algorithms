using System.Collections.Generic;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_36_RandomQueueIterator
    {
        [Test]
        public void Smoke()
        {
            var itemsAmount = 10;
            var possibleItems = new HashSet<int>();
            var randomQueue = new RandomQueue<int>();

            for (var i = 0; i < itemsAmount; i++)
            {
                possibleItems.Add(i);
                randomQueue.Enqueue(i);
            }
            
            Assert.AreEqual(itemsAmount, randomQueue.Count);
            Assert.AreEqual(itemsAmount, possibleItems.Count);
            
            foreach (var i in randomQueue)
            {
                possibleItems.Remove(i);
            }
            
            Assert.AreEqual(itemsAmount, randomQueue.Count);
            Assert.Zero(possibleItems.Count);
        }
    }
}