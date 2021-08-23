namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_13_MatrixTransposition
    {
        public int[,] TranspondMatrix(int[,] matrix)
        {
            var result = new int[matrix.GetLength(1), matrix.GetLength(0)];

            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix.Length; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            
            return result;
        }
    }
}