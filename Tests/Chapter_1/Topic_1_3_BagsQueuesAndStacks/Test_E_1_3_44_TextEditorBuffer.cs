using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_44_TextEditorBuffer
    {
        [Test]
        public void Smoke()
        {
            var buffer = new E_1_3_44_TextEditorBuffer();
            
            buffer.Insert('L');
            buffer.Insert('o');
            buffer.Insert('r');
            buffer.Insert('e');
            buffer.Insert('m');
            Assert.AreEqual(5, buffer.Size);

            Assert.AreEqual('m', buffer.Delete());
            Assert.AreEqual(4, buffer.Size);
            
            buffer.Left(2);
            Assert.AreEqual('o', buffer.Delete());
            Assert.AreEqual(3, buffer.Size);
            
            buffer.Right(2);
            Assert.AreEqual('e', buffer.Delete());
            Assert.AreEqual(2, buffer.Size);
        }
    }
}