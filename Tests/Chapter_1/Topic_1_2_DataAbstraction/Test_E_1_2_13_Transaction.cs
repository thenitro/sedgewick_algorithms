using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction;

namespace Tests.Chapter_1.Topic_1_2_DataAbstraction
{
    [TestFixture]
    public class Test_E_1_2_13_Transaction
    {
        [Test]
        public void SmokeTest()
        {
            var transaction = new Transaction("Tymur", new Date(4, 4, 2024), 100);
            
            Assert.AreEqual("Tymur", transaction.Customer);
            Assert.AreEqual(new Date(4, 4, 2024), transaction.Date);
            Assert.AreEqual(100, transaction.Amount);
            Assert.AreEqual(new Transaction("Tymur", new Date(4, 4, 2024), 100), transaction);
        }
    }
}