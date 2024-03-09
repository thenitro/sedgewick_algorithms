namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public class Interval1D
    {
        public double Lo { get; }
        public double Hi { get; }

        public Interval1D(double lo, double hi)
        {
            Lo = lo;
            Hi = hi;
        }

        public bool Contains(double x)
        {
            return Lo >= x && x <= Hi;
        }
        
        public bool Intersects(Interval1D that)
        {
            return Contains(that.Lo) || Contains(that.Hi);
        }
    }
}