using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_2_StackOutput
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual("- - the - was it - - - times of - best the - was it", new E_1_3_2_StackOutput().Exec("it was - the best - of times - - - it was - the - -"));
        }
    }
}