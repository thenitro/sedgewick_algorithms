using System.Collections.Generic;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class TestE_1_3_46_ForbiddenTripleStackGenerability
    {
        [TestCase]
        public void Smoke()
        {
            Assert.False(new E_1_3_46_ForbiddenTripleStackGenerability().CanGenerate(new List<int> { 1, 2, 0 }));
            Assert.False(new E_1_3_46_ForbiddenTripleStackGenerability().CanGenerate(new List<int> { 3, 4, 1, 2 }));
            Assert.False(new E_1_3_46_ForbiddenTripleStackGenerability().CanGenerate(new List<int> { 3, 4, 1, 2 }));
            Assert.False(new E_1_3_46_ForbiddenTripleStackGenerability().CanGenerate(new List<int> { 5, 2, 3, 4, 1 }));
            Assert.False(new E_1_3_46_ForbiddenTripleStackGenerability().CanGenerate(new List<int> { 5, 2, 3, 4, 1 }));
            Assert.False(new E_1_3_46_ForbiddenTripleStackGenerability().CanGenerate(new List<int> { 4, 5, 6, 1, 2, 3 }));
            Assert.True(new E_1_3_46_ForbiddenTripleStackGenerability().CanGenerate(new List<int> { 5, 4, 3, 2, 1, 6, 7, 8, 9, 10 }));
            Assert.True(new E_1_3_46_ForbiddenTripleStackGenerability().CanGenerate(new List<int> { 2, 0, 1 }));
            Assert.True(new E_1_3_46_ForbiddenTripleStackGenerability().CanGenerate(new List<int> { 1, 0, 2 }));
            Assert.True(new E_1_3_46_ForbiddenTripleStackGenerability().CanGenerate(new List<int> { 0, 1, 2 }));
            Assert.True(new E_1_3_46_ForbiddenTripleStackGenerability().CanGenerate(new List<int> { 2, 1, 0 }));
        }
    }
}