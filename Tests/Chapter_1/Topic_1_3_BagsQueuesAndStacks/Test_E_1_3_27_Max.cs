using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_27_Max
    {
        [Test]
        public void Smoke()
        {
            var firstNode = new LinkedListNode<uint>(1, new LinkedListNode<uint>(2, new LinkedListNode<uint>(3)));
            
            Assert.AreEqual(3, new E_1_3_27_Max().Solution(firstNode));
        }
        
        [Test]
        public void Empty()
        {
            Assert.AreEqual(0, new E_1_3_27_Max().Solution(null));
        }
    }
}