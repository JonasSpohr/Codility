namespace TopTalChallenge_JS
{
    public class FrogRiverOne
    {
        public int run(int X, int[] A)
        {
            int result = -1;
            int[] B = new int[X];
            int sumB = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int c = A[i] - 1;

                if (B[c] == 0)
                {
                    B[c] = 1;
                    sumB += 1;
                }

                if (sumB == X)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}
