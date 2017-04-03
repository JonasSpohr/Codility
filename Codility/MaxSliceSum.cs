namespace Codility
{
    public class MaxSliceSum
    {
        public int run(int[] A)
        {
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    sum += A[i];

                    if (max < sum)
                        max = sum;

                    if (sum < 0)
                        sum = 0;

                }
                else if (A[i] == 0)
                {
                    max = max < sum ? sum : max;
                }
                else
                {
                    while (i < A.Length && A[i] > 0)
                    {
                        sum += A[i];
                        i++;
                    }

                    if (max < sum)
                        max = sum;

                    i--;
                }
            }

            return max;
        }
    }
}
