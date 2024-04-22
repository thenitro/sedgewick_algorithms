using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_3_PushPop
    {
        [Test]
        public void Smoke()
        {
            Assert.True(new E_1_3_3_PushPop().CanOccur(new []{ 4, 3, 2, 1, 0, 9, 8, 7, 6, 5 }));//a
            Assert.False(new E_1_3_3_PushPop().CanOccur(new []{ 4, 6, 8, 7, 5, 3, 2, 9, 0, 1 }));//b
            Assert.True(new E_1_3_3_PushPop().CanOccur(new []{ 2, 5, 6, 7, 4, 8, 9, 3, 1, 0 }));//c
            Assert.True(new E_1_3_3_PushPop().CanOccur(new []{ 4, 3, 2, 1, 0, 5, 6, 7, 8, 9 }));//d
            Assert.True(new E_1_3_3_PushPop().CanOccur(new []{ 1, 2, 3, 4, 5, 6, 9, 8, 7, 0 }));//e
            Assert.False(new E_1_3_3_PushPop().CanOccur(new []{ 0, 4, 6, 5, 3, 8, 1, 7, 2, 0 }));//f
            Assert.False(new E_1_3_3_PushPop().CanOccur(new []{ 1, 4, 7, 9, 8, 6, 5, 3, 0, 2 }));//g
            Assert.True(new E_1_3_3_PushPop().CanOccur(new []{ 2, 1, 4, 3, 6, 5, 8, 7, 9, 0 }));//h
        }
    }
}