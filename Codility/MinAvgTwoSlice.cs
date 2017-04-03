using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MinAvgTwoSlice
    {
        public int run(int[] A)
        {
            int result = 0;
            decimal min = 10000;
            decimal[] by2 = new decimal[A.Length - 1];
            decimal[] by3 = new decimal[A.Length - 2];


            for (int i = 1; i < A.Length; i++)
            {
                var avg = decimal.Divide(A[i - 1] + A[i], 2);
                by2[i - 1] = avg;
                if (min > avg)
                {
                    min = avg;
                    result = i - 1;
                }
            }

            for (int i = 2; i < A.Length; i++)
            {
                var avg = decimal.Divide(A[i - 2] + A[i - 1] + A[i], 3);
                by3[i - 2] = avg;
                if (min > avg)
                {
                    min = avg;
                    result = i - 2;
                }
            }

            return result;
        }
    }
}
