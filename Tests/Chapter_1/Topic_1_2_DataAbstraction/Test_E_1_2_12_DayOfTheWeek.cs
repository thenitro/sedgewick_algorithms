using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction;

namespace Tests.Chapter_1.Topic_1_2_DataAbstraction
{
    [TestFixture]
    public class Test_E_1_2_12_DayOfTheWeek
    {
        [Test]
        [TestCase(4, 1, 2024, "Monday")]
        [TestCase(4, 2, 2024, "Tuesday")]
        [TestCase(4, 3, 2024, "Wednesday")]
        [TestCase(4, 4, 2024, "Thursday")]
        [TestCase(4, 5, 2024, "Friday")]
        [TestCase(4, 6, 2024, "Saturday")]
        [TestCase(4, 7, 2024, "Sunday")]
        public void DayOfTheWeekTest(int month, int day, int year, string expectedDay)
        {
            Assert.AreEqual(expectedDay, new SmartDate(month, day, year).DayOfTheWeek());
        }
    }
}