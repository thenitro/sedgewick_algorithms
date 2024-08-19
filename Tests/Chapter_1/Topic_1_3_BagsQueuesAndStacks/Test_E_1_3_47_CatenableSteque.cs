using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_47_CatenableSteque
    {
        [Test]
        public void Smoke()
        {
            var a = new E_1_3_32_Steque<int>();
            a.Push(1);
            a.Push(2);
            a.Push(3);
            var b = new E_1_3_32_Steque<int>();
            b.Push(4);
            b.Push(5);
            b.Push(6);

            a.Concat(b);
            
            Assert.AreEqual(6, a.Pop());
            Assert.AreEqual(5, a.Pop());
            Assert.AreEqual(4, a.Pop());
            Assert.AreEqual(3, a.Pop());
            Assert.AreEqual(2, a.Pop());
            Assert.AreEqual(1, a.Pop());
        }
    }
}