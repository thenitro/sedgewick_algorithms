using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction;

namespace Tests.Chapter_1.Topic_1_2_DataAbstraction
{
    [TestFixture]
    public class Test_E_1_2_14_TransactionEquals
    {
        [Test]
        public void Smoke()
        {
            var transaction = new Transaction("Tymur", new Date(4, 4, 2024), 100);
            Assert.AreEqual(new Transaction("Tymur", new Date(4, 4, 2024), 100), transaction);
        }
    }
}