namespace ProjectEuler
{
    public static class Multiples
    {
        public static int FindMulti3or5(int n = 1000)
        {
            int sum = 0;
            for (int i = 3; i < n; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}