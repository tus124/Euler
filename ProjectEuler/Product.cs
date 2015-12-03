using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class Series
    {
        public string Product { get; set; }
        public long Value { get; set; }
    }

    public static class Product
    {
        public static long GetLargestProduct(int[] series, int k)
        {
            List<Series> results = new List<Series>();

            for (int i = 0; i < series.Length - k; i++)
            {
                long multiply = 1;
                StringBuilder sb = new StringBuilder();

                for (int j = i; j < k + i; j++)
                {
                    sb.Append(series[j]);
                    multiply *= series[j];
                }

                Series s = new Series();
                s.Product = sb.ToString();
                s.Value = multiply;

                results.Add(s);
            }

            results.Sort((x1, x2) => x1.Value.CompareTo(x2.Value));

            return results[results.Count - 1].Value;
        }

        public static long FindLargestProduct(int[,] s, int length)
        {
            List<long> results = new List<long>();

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    long sum_leftToRight = 1, sum_upToDown = 1, sum_diagonial = 1;
                    for (int k = j; k <= j + 3 && j + 3 < length - 1; k++)
                    {
                        sum_leftToRight *= s[i, k];
                        sum_upToDown *= s[k,i];
                        sum_diagonial *= s[k, k];

                    }
                    if(sum_leftToRight > 0)
                        results.Add(sum_leftToRight);

                    if(sum_upToDown > 0)
                        results.Add(sum_upToDown);

                    if(sum_diagonial > 0)
                        results.Add(sum_diagonial);
                }
            }

            results.Sort();

            return results[results.Count -1];
        }
    }
}