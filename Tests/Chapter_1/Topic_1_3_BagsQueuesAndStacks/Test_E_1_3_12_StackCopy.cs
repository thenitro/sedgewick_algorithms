using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_12_StackCopy
    {
        [Test]
        public void BasicOperationsTest()
        {
            var stack = new TStack<string>();
            Assert.AreEqual(0, stack.Count);
            
            stack.Push("a");
            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual("a", stack.Peek());
            Assert.AreEqual("a", stack.Pop());
            Assert.AreEqual(0, stack.Count);
            
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            Assert.AreEqual(3, stack.Count);
            Assert.AreEqual("c", stack.Pop());
            Assert.AreEqual("b", stack.Pop());
            Assert.AreEqual("a", stack.Pop());
            Assert.AreEqual(0, stack.Count);
        }

        [Test]
        public void EnumeratorTest()
        {
            var stack = new TStack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var enumerator = stack.GetEnumerator();
            
            Assert.AreEqual(null, enumerator.Current);
            Assert.True(enumerator.MoveNext());
            Assert.AreEqual("c", enumerator.Current);
            Assert.True(enumerator.MoveNext());
            Assert.AreEqual("b", enumerator.Current);
            Assert.True(enumerator.MoveNext());
            Assert.AreEqual("a", enumerator.Current);
            Assert.False(enumerator.MoveNext());
        }

        [Test]
        public void Smoke()
        {
            var stack = new TStack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            var copyStack = stack.Copy();
            Assert.False(stack == copyStack);
            Assert.AreEqual("c", copyStack.Pop());
            Assert.AreEqual("b", copyStack.Pop());
            Assert.AreEqual("a", copyStack.Pop());
        }
    }
}