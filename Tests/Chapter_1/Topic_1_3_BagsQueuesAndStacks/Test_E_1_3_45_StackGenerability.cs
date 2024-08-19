using System.Collections.Generic;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_45_StackGenerability
    {
        [Test]
        public void SmokeIsUnderflow()
        {
            Assert.True(new E_1_3_45_StackGenerability().IsUnderflow(new List<char> { '-' }));
            Assert.False(new E_1_3_45_StackGenerability().IsUnderflow(new List<char> { '1', '2', '3' }));
            Assert.True(new E_1_3_45_StackGenerability().IsUnderflow(new List<char> { '3', '-', '1', '-', '-' }));
            Assert.False(new E_1_3_45_StackGenerability().IsUnderflow(new List<char> { '3', '-', '1', '-' }));
        }

        [Test]
        public void IsPermutation()
        {
            Assert.True(new E_1_3_45_StackGenerability().IsPermutation(new List<int> { 2, 1, 0 }));
            Assert.False(new E_1_3_45_StackGenerability().IsPermutation(new List<int> { 4, 1, 2 }));
            Assert.True(new E_1_3_45_StackGenerability().IsPermutation(new List<int> { 4, 3, 2, 1, 0, 5 }));
            Assert.False(new E_1_3_45_StackGenerability().IsPermutation(new List<int> { 4, 1, 2, 3, 8 }));
        }
    }
}