using System;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction;

namespace Tests.Chapter_1.Topic_1_2_DataAbstraction
{
    [TestFixture]
    public class Test_E_1_2_2_IntersectedIntervals
    {
        [Test]
        public void IntervalsContainsSmoke()
        {
            var interval = new Interval1D(1, 3);
            var a = 2;
            var b = 4;
            
            Assert.True(interval.Lo <= a);
            Assert.True(interval.Hi >= a);
            Assert.True(interval.Lo <= b);
            Assert.False(interval.Hi >= b);
            Assert.True(interval.Contains(a));
            Assert.False(interval.Contains(b));
        }
        
        [Test]
        public void IntervalsIntersectsSmoke()
        {
            var intervalA = new Interval1D(1, 3);
            var intervalB = new Interval1D(2, 4);

            Assert.True(intervalA.Intersects(intervalB));
            Assert.True(intervalB.Intersects(intervalA));
        }
        
        [Test]
        [TestCase(100, 0, 100)]
        public void SmokeTest(int N, double lo, double hi)
        {
            //feeling lazy to figure out input, lets generate it
            var range = hi - lo;
            var intervals = new Interval1D[N];

            for (var i = 0; i < N; i++)
            {
                var newLo = new Random().NextDouble() * range;
                var newHi = new Random().NextDouble() * (range - newLo); 
                intervals[i] = new Interval1D(lo + newLo, lo + newHi);
            }

            var pairs = new E_1_2_2_IntersectedIntervals().GetIntersectedIntervals(intervals);
            
            Assert.AreNotEqual(0, pairs.Count);

            foreach (var (intervalA, intervalB) in pairs)
            {
                var loContains = intervalA.Lo <= intervalB.Lo && intervalB.Lo <= intervalA.Hi;
                var hiContains = intervalA.Lo <= intervalB.Hi && intervalB.Hi <= intervalA.Hi;
                
                Assert.True(loContains || hiContains);
            }
        }
    }
}