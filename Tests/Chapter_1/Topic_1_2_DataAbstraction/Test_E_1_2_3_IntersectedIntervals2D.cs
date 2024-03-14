using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction;

namespace Tests.Chapter_1.Topic_1_2_DataAbstraction
{
    [TestFixture]
    public class Test_E_1_2_3_IntersectedIntervals2D
    {
        [Test]
        public void IntersectedIntervalsSmoke()
        {
            var intervalA = new Interval2D(new Interval1D(1, 3), new Interval1D(1, 3));
            var intervalB = new Interval2D(new Interval1D(2, 4), new Interval1D(2, 4));
            
            Assert.True(intervalA.X.Intersects(intervalB.X));
            Assert.True(intervalA.Y.Intersects(intervalB.Y));
            Assert.True(intervalA.Intersects(intervalB));
            Assert.True(intervalB.Intersects(intervalA));
        }
        
        [Test]
        public void IntersectedIntervalsOneInsideTheOther()
        {
            var intervalA = new Interval2D(new Interval1D(1, 5), new Interval1D(1, 5));
            var intervalB = new Interval2D(new Interval1D(2, 4), new Interval1D(2, 4));
            
            Assert.True(intervalA.Intersects(intervalB));
            Assert.True(intervalB.Intersects(intervalA));
        }
    }
}