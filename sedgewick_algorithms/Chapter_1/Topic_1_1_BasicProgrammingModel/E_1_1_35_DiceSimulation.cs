namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_35_DiceSimulation
    {
        public double[] GetDistribution()
        {
            int SIDES = 6;
            double[] dist = new double[2 * SIDES + 1];

            for (var i = 1; i <= SIDES; i++)
            {
                for (var j = 1; j <= SIDES; j++)
                {
                    dist[i + j] += 1.0;
                }
            }

            for (var k = 2; k <= 2 * SIDES; k++)
            {
                dist[k] /= 36.0;
            }

            return dist;
        }
    }
}