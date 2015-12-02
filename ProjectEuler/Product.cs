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

        public static long FindLargestProduct(int[,] s)
        {
            List<long> results = new List<long>();

            for (int i = 0; i < 20 - 1; i++)
            {
                for (int j = 0; j < 20 - 1; j++)
                {
                    long sum = 1;
                    for (int k = j; k < j + 3 && j+3 < 20 - 1; k++)
                    {
                        sum *= s[i, k];
                    }
                    
                    results.Add(sum);
                }
            }



            results.Sort();

            return results[results.Count -1];
        }
    }
}