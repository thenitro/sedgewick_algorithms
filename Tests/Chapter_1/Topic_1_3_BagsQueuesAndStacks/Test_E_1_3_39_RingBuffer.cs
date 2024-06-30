using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_39_RingBuffer
    {
        [Test]
        public void Smoke()
        {
            var buffer = new E_1_3_39_RingBuffer<int>(5);
            Assert.Zero(buffer.Count);
            
            buffer.Enqueue(1);
            buffer.Enqueue(2);
            buffer.Enqueue(3);
            
            Assert.AreEqual(3, buffer.Count);

            var circularEnumeration = new [] { 1, 2, 3, 1, 2, 3 };
            var count = 0;

            foreach (var value in buffer)
            {
                Assert.AreEqual(circularEnumeration[count], value);
                
                count++;
                
                if (count == circularEnumeration.Length)
                {
                    break;
                }
            }
            
            Assert.AreEqual(1, buffer.Dequeue());
            Assert.AreEqual(2, buffer.Dequeue());
            Assert.AreEqual(3, buffer.Dequeue());
            Assert.Zero(buffer.Count);
            
            buffer.Enqueue(4);
            buffer.Enqueue(5);
            buffer.Enqueue(6);
            buffer.Enqueue(7);
            buffer.Enqueue(8);
            
            Assert.AreEqual(4, buffer.Dequeue());
            Assert.AreEqual(5, buffer.Dequeue());
            Assert.AreEqual(6, buffer.Dequeue());
            Assert.AreEqual(7, buffer.Dequeue());
            Assert.AreEqual(8, buffer.Dequeue());
            Assert.Zero(buffer.Count);
        }
    }
}