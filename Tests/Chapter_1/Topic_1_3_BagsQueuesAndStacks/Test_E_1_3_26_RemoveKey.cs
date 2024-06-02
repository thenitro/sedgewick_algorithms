using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_26_RemoveKey
    {
        [Test]
        public void AllSameKey()
        {
            var list = new TLinkedList<string>(new LinkedListNode<string>("1", new LinkedListNode<string>("1", new LinkedListNode<string>("1"))));
            new E_1_3_26_RemoveKey().Solution(list, "1");
            Assert.Null(list.First);
        }
        
        [Test]
        public void NoKey()
        {
            var list = new TLinkedList<string>(new LinkedListNode<string>("1", new LinkedListNode<string>("1", new LinkedListNode<string>("1"))));
            new E_1_3_26_RemoveKey().Solution(list, "-1");
            Assert.AreEqual("1", list.First.Value);
            Assert.AreEqual("1", list.First.Next.Value);
            Assert.AreEqual("1", list.First.Next.Next.Value);
        }
        
        [Test]
        public void First()
        {
            var list = new TLinkedList<string>(new LinkedListNode<string>("-1", new LinkedListNode<string>("1", new LinkedListNode<string>("1"))));
            new E_1_3_26_RemoveKey().Solution(list, "-1");
            Assert.AreEqual("1", list.First.Value);
            Assert.AreEqual("1", list.First.Next.Value);
        }
        
        [Test]
        public void Last()
        {
            var list = new TLinkedList<string>(new LinkedListNode<string>("1", new LinkedListNode<string>("1", new LinkedListNode<string>("-1"))));
            new E_1_3_26_RemoveKey().Solution(list, "-1");
            Assert.AreEqual("1", list.First.Value);
            Assert.AreEqual("1", list.First.Next.Value);
        }
        
        [Test]
        public void Smoke()
        {
            var list = new TLinkedList<string>(new LinkedListNode<string>("1", new LinkedListNode<string>("-1", new LinkedListNode<string>("1"))));
            new E_1_3_26_RemoveKey().Solution(list, "-1");
            Assert.AreEqual("1", list.First.Value);
            Assert.AreEqual("1", list.First.Next.Value);
        }
        
        [Test]
        public void Null()
        {
            new E_1_3_26_RemoveKey().Solution(null, "-1");
        }
    }
}