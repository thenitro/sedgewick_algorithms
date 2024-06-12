using System.Collections.Generic;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_34_RandomBag
    {
        [Test]
        public void Smoke()
        {
            var itemsToAdd = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var bag = new E_1_3_34_RandomBag<int>();
            Assert.True(bag.IsEmpty);
            Assert.Zero(bag.Count);

            foreach (var i in itemsToAdd)
            {
                bag.Add(i);
            }
            
            Assert.False(bag.IsEmpty);
            Assert.AreEqual(itemsToAdd.Count, bag.Count);

            foreach (var i in bag)
            {
                itemsToAdd.Remove(i);
            }
            
            Assert.Zero(itemsToAdd.Count);
        }
    }
}