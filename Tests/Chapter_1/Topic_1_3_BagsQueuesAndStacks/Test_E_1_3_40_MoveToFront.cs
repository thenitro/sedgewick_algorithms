using System.Collections.Generic;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_40_MoveToFront
    {
        [Test]
        public void Smoke()
        {
            var list = new E_1_3_40_MoveToFront<int>();
            Assert.Zero(list.Front);
            
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            
            Assert.AreEqual(5, list.Front);
            
            var set = new HashSet<int>() { 1, 2, 3, 4, 5 };
            var itemsToIterate = set.Count;

            foreach (var i in list)
            {
                set.Remove(i);
                itemsToIterate--;
            }
            
            Assert.Zero(set.Count);
            Assert.Zero(itemsToIterate);
        }
    }
}