using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class AmicableNumber
    {
      
        public static List<int> getProperDivisor(int n)
        {
            var arr = new List<int>();
            for(int i=1; i<=n/2; i++)
            {
                if(n % i == 0)
                {
                    arr.Add(i);
                }
            }

            return arr;
        }

        public static int getSum(List<int> arr)
        {
            int sum = 0;
            for(int i=0; i<arr.Count; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static bool isAmicableNumber(int k, out int results)
        {
            int p = getSum(getProperDivisor(k));
            int q = getSum(getProperDivisor(p));
            if (k != p && k == q)
            {
                results = p;
                return true;
            }
            results = 0;
            return false;
        }

        public static int GetAllAmicableNumbers(int n)
        {
            List<int> results = new List<int>();
            for (int i = 1; i <= n; i++)
            {

                if (!results.Contains(i))
                {
                    int j = 0;
                    bool isAN = isAmicableNumber(i, out j);
                    if (isAN)
                    {
                        results.Add(i);
                        results.Add(j);
                    }
                }



            }

            return getSum(results);
        }
    }
}
