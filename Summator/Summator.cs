using System;
namespace Summator

{
    public static class Summator

    {
        public static long Sum(int[] Array)
        {
            long sum = 0;

            for (long i = 0; i < Array.Length; i++)
            {
                sum += Array[i];

            }
            return sum;

        }
        public static int Average(int[] Array)
        {
            int sum = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                sum += Array[i];

            }
            return sum / Array.Length;
        }
    }
}
