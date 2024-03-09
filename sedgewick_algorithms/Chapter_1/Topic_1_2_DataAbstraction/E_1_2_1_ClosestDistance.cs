namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public class E_1_2_1_ClosestDistance
    {
        public (Point2D, Point2D) GetClosestPair(Point2D[] points)
        {
            var closest = double.MaxValue;
            (Point2D, Point2D) closestPoints = (null, null);
            
            foreach (var pointA in points)
            {
                foreach (var pointB in points)
                {
                    if (pointA == pointB) continue;
                    
                    var currentDistance = pointA.DistanceTo(pointB);
                    if (currentDistance < closest)
                    {
                        closest = currentDistance;
                        closestPoints = (pointA, pointB);
                    }
                }
            }

            return closestPoints;
        }
    }
}