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
            List<Series> results = new List<Series>();

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    long sum_leftToRight = 1, sum_upToDown = 1;
                    long sum_diagonial_bottomRightToTopLeft = 1;
                    long sum_diagonial_bottomRightToTopRight = 1;
                    long sum_diagonial_topRightToBottomLeft = 1;
                    long sum_diagonial_topRightToBottomRight = 1;

                    StringBuilder leftToRight = new StringBuilder();
                    StringBuilder upToDown = new StringBuilder();
                    StringBuilder diagonial_bottomRightToTopLeft = new StringBuilder();
                    StringBuilder diagonial_bottomRightToTopRight = new StringBuilder();
                    StringBuilder diagonial_topRightToBottomLeft = new StringBuilder();
                    StringBuilder diagonial_topRightToBottomRight = new StringBuilder();

                    for (int k = j; k <= j + 3 && j + 3 < length - 1 && i + k < length - 1 && j + k < length - 1; k++)
                    {
                        leftToRight.Append(s[i, k] + ",");
                        sum_leftToRight *= s[i, k];

                        upToDown.Append(s[k, i] + ",");
                        sum_upToDown *= s[k, i];
                    }

                    if (sum_leftToRight > 1) results.Add(new Series() { Product = leftToRight.ToString(), Value = sum_leftToRight });
                    if (sum_upToDown > 1) results.Add(new Series() { Product = upToDown.ToString(), Value = sum_upToDown });

                    if (i >= 3 && j >= 3 && i < length - 4 && j < length - 4)
                    {
                        diagonial_bottomRightToTopLeft.Append(s[i - 0, j - 0] + "," + s[i - 1, j - 1] + "," + s[i - 2, j - 2] + "," + s[i - 3, j - 3]);
                        diagonial_bottomRightToTopRight.Append(s[i - 0, j + 0] + "," + s[i - 1, j + 1] + "," + s[i - 2, j + 2] + "," + s[i - 3, j + 3]);
                        diagonial_topRightToBottomLeft.Append(s[i + 0, j - 0] + "," + s[i + 1, j - 1] + "," + s[i + 2, j - 2] + "," + s[i + 3, j - 3]);
                        diagonial_topRightToBottomRight.Append(s[i + 0, i + 0] + "," + s[i + 1, j + 1] + "," + s[i + 2, j + 2] + "," + s[i + 3, j + 3]);

                        sum_diagonial_bottomRightToTopLeft = s[i - 0, j - 0] * s[i - 1, j - 1] * s[i - 2, j - 2] * s[i - 3, j - 3];
                        sum_diagonial_bottomRightToTopRight = s[i - 0, j + 0] * s[i - 1, j + 1] * s[i - 2, j + 2] * s[i - 3, j + 3];
                        sum_diagonial_topRightToBottomLeft = s[i + 0, j - 0] * s[i + 1, j - 1] * s[i + 2, j - 2] * s[i + 3, j - 3];
                        sum_diagonial_topRightToBottomRight = s[i + 0, i + 0] * s[i + 1, j + 1] * s[i + 2, j + 2] * s[i + 3, j + 3];
                    }

                    if (sum_diagonial_bottomRightToTopLeft > 1) results.Add(new Series() { Product = diagonial_bottomRightToTopLeft.ToString(), Value = sum_diagonial_bottomRightToTopLeft });
                    if (sum_diagonial_bottomRightToTopRight > 1) results.Add(new Series() { Product = diagonial_bottomRightToTopRight.ToString(), Value = sum_diagonial_bottomRightToTopRight });
                    if (sum_diagonial_topRightToBottomLeft > 1) results.Add(new Series() { Product = diagonial_topRightToBottomLeft.ToString(), Value = sum_diagonial_topRightToBottomLeft });
                    if (sum_diagonial_topRightToBottomRight > 1) results.Add(new Series() { Product = diagonial_topRightToBottomRight.ToString(), Value = sum_diagonial_topRightToBottomRight });
                }
            }

            results.Sort((x1, x2) => x1.Value.CompareTo(x2.Value));

            return results[results.Count - 1].Value;
        }
    }
}