using System.Collections.Generic;

namespace LargeNumbers
{
    public static class LargeSum
    {
        public static string Add(List<string> str)
        {
            string sum = str[0];
            for (int i = 1; i < str.Count; i++)
            {
                sum = Add(sum, str[i]);
            }

            return sum;
        }

        public static string Add(string p, string q)
        {
            int temp = 0;
            int carry = 0;

            List<int> sum = new List<int>();

            int i = p.Length - 1;
            int j = q.Length - 1;

            while (i >= 0 && j >= 0)
            {
                int a = int.Parse(p[i--].ToString());
                int b = int.Parse(q[j--].ToString());

                temp = a + b + carry;
                sum.Add(temp % 10);
                carry = temp / 10;
            }
            while (i >= 0)
            {
                int a = int.Parse(p[i--].ToString());
                temp = a + carry;
                sum.Add(temp % 10);
                carry = temp / 10;
            }
            while (j >= 0)
            {
                int b = int.Parse(q[j--].ToString());
                temp = b + carry;
                sum.Add(temp % 10);
                carry = temp / 10;
            }

            if (carry > 0)
            {
                sum.Add(carry);
            }

            return sum.ReverseList().GetString();
        }
    }
}