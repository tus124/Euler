namespace ProjectEuler
{
    public static class Fibonancci
    {
        public static long FindFibEvenSum(int n = 15)
        {
            long sum = 0;
            int first = 1, second = 2;
            int next;

            sum += second;
            for (int i = 2; i < n; i++)
            {
                next = first + second;
                if (next % 2 == 0)
                {
                    sum += next;
                }
                first = second;
                second = next;
            }
            return sum;
        }
    }
}