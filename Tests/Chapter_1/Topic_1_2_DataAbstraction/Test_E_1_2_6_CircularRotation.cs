using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction;

namespace Tests.Chapter_1.Topic_1_2_DataAbstraction
{
    [TestFixture]
    public class Test_E_1_2_6_CircularRotation
    {
        [Test]
        public void Smoke()
        {
            Assert.True(new E_1_2_6_CircularRotation().IsCircularRotation("ACTGACG", "TGACGAC"));
        }
    }
}