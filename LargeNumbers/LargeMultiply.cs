using System.Collections.Generic;

namespace LargeNumbers
{
    public static class LargeMultiply
    {
        public static string Multiply(string s, string r)
        {
            if (s.Length < r.Length)
            {
                HelperExtension.Swap(ref s, ref r);
            }

            List<string> results = new List<string>();
            int j = r.Length - 1;
            int k = 0;
            while (j >= 0)
            {
                List<int> multi = new List<int>();
                int temp = 0;
                int carry = 0;
                for (int index = 0; index < k; index++)
                {
                    multi.Add(0);
                }

                int i = s.Length - 1;
                while (i >= 0)
                {
                    int a = int.Parse(s[i].ToString());
                    int b = int.Parse(r[j].ToString());
                    temp = (a * b) + carry;
                    multi.Add(temp % 10);
                    carry = temp / 10;
                    i--;
                }

                if (carry > 0)
                {
                    multi.Add(carry);
                }

                results.Add(multi.ReverseList().GetString());
                j--;
                k++;
            }

            return LargeSum.Add(results);
        }
    }
}