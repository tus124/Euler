using LargeNumbers;
using System.Collections.Generic;

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

        public static bool isAmicableNumber(int k, out int results)
        {
            int p = getProperDivisor(k).GetSum();
            int q = getProperDivisor(p).GetSum();
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

            return results.GetSum();
        }
    }
}
