using System;

namespace ProjectEuler
{
    public static class SumOfTriangle
    {
        public static int MaxPathSum(int[] triangle)
        {
            int size = (triangle.Length / sizeof(int));
            int tn = Convert.ToInt32(Math.Sqrt(2.0 * size));

            for (int n = tn - 1; n > 0; --n)
            {
                for (int k = (n * (n - 1)) / 2; k < (n * (n + 2)); ++k)
                {
                    triangle[k] += Math.Max(triangle[k + n], triangle[k + n + 1]);
                }
            }

            int result = triangle[0];

            return result;
        }
    }
}