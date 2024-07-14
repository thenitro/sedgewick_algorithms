using System.Collections.Generic;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_42_CopyStack
    {
        [Test]
        public void Smoke()
        {
            var amountOfElements = 5;
            var t = new Stack<int>();

            for (var i = 0; i < amountOfElements; i++)
            {
                t.Push(i);
            }
            
            var s = new E_1_3_42_CopyStack().Solution(t);
            
            Assert.False(t == s);
            for (var i = amountOfElements - 1; i >= 0; i--)
            {
                Assert.AreEqual(i, t.Peek());
                Assert.AreEqual(i, s.Peek());
                Assert.AreEqual(t.Pop(), s.Pop());
            }
        }
    }
}