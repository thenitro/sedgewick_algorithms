using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_33_MatrixLibrary
    {
        public static double Dot(double[] x, double[] y)
        {
            if (x.Length != y.Length)
            {
                throw new ArgumentException("Vectors should be equal sized!");
            }

            var result = 0.0;

            for (var i = 0; i < x.Length; i++)
            {
                result += x[i] * y[i];
            }

            return result;
        }

        public static double[][] Mult(double[][] a, double[][] b)
        {
            var m = a.Length;
            var p = b[0].Length;
            
            if (m != p)
            {
                throw new ArgumentException(
                    "Number of columns of matrix A should be equal to number of rows of matrix B");
            }

            var n = a[0].Length;
            var result = new double[m][];

            for (var i = 0; i < m; i++)
            {
                result[i] = new double[p];
            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < p; j++)
                {
                    var sum = 0.0;

                    for (var k = 0; k < n; k++)
                    {
                        sum += a[i][k] * b[k][j];
                    }

                    result[i][j] = sum;
                }
            }

            return result;
        }

        public static double[][] Transpose(double[][] a)
        {
            var m = a.Length;
            var n = a[0].Length;

            var result = new double[n][];

            for (var i = 0; i < n; i++)
            {
                result[i] = new double[m];
            }
            
            for (var row = 0; row < m; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    result[col][row] = a[row][col];
                }
            }

            return result;
        }

        public static double[] Mult(double[][] a, double[] x)
        {
            var N = a.Length;
            var result = new double[N];

            for (var row = 0; row < N; row++)
            {
                result[row] = Dot(a[row], x);
            }

            return result;
        }

        public static double[] Mult(double[] x, double[][] a)
        {
            var M = a.Length;
            var N = x.Length;
            var result = new double[N];

            for (var col = 0; col < N; col++)
            {
                var dot = 0.0;
                var vectorValue = x[col];

                for (var row = 0; row < M; row++)
                {
                    dot += vectorValue * a[row][col];
                }

                result[col] = dot;
            }

            return result;
        }
    }
}