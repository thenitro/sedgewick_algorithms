using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public class E_1_2_2_IntersectedIntervals
    {
        public List<(Interval1D, Interval1D)> GetIntersectedIntervals(Interval1D[] intervalsInput)
        {
            var result = new List<(Interval1D, Interval1D)>();
            
            foreach (var intervalA in intervalsInput)
            {
                foreach (var intervalB in intervalsInput)
                {
                    if (intervalA.Intersects(intervalB))
                    {
                        result.Add((intervalA, intervalB));
                    }
                }
            }

            return result;
        }
    }
}