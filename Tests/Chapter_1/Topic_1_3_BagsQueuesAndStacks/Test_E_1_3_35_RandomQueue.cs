using System.Collections.Generic;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_35_RandomQueue
    {
        [Test]
        public void SmokeTest()
        {
            const int itemsAmount = 10;
            
            var possibleItems = new HashSet<int>();
            var queueToTest = new E_1_3_35_RandomQueue<int>();
            
            for (var i = 0; i < itemsAmount; i++)
            {
                possibleItems.Add(i);
                queueToTest.Enqueue(i);
            }

            while (!queueToTest.IsEmpty)
            {
                possibleItems.Remove(queueToTest.Dequeue());
            }
            
            Assert.Zero(possibleItems.Count);
        }
    }
}