using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_21_Find
    {
        [Test]
        public void Smoke()
        {
            var list = new TLinkedList<string>(new Node<string>("1", new Node<string>("2", new Node<string>("3"))));
            
            Assert.False(new E_1_3_21_Find().Solution(list, "0"));
            Assert.True(new E_1_3_21_Find().Solution(list, "1"));
            Assert.True(new E_1_3_21_Find().Solution(list, "2"));
            Assert.True(new E_1_3_21_Find().Solution(list, "3"));
            Assert.False(new E_1_3_21_Find().Solution(list, "4"));
        }
    }
}