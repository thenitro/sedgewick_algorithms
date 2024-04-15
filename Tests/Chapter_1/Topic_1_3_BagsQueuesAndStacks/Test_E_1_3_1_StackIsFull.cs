using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_1_StackIsFull
    {
        [Test]
        public void SmokeTest()
        {
            var stack = new FixedCapacityStackOfStrings(3);
            Assert.False(stack.IsFull);
            
            stack.Push("1");
            Assert.False(stack.IsFull);
            
            stack.Push("2");
            Assert.False(stack.IsFull);
            
            stack.Push("3");
            Assert.True(stack.IsFull);

            stack.Pop();
            Assert.False(stack.IsFull);
        }
    }
}