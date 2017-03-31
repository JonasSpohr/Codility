using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTalChallenge_JS
{
    public class MaxCounters
    {
        public int[] run(int N, int[] A)
        {
            int[] counters = new int[N];

            int min = int.MinValue;
            int tmin = 0;

            for (int i = 0; i < A.Length; ++i)
            {
                int index = A[i] - 1;
                if (index == N)
                {
                    min = tmin;
                }
                else
                {
                    if (counters[index] < min)
                    {
                        counters[index] = min;
                    }

                    counters[index] = counters[index] + 1;

                    if (tmin < counters[index])
                    {
                        tmin = counters[index];
                    }
                }
            }

            for (int i = 0; i < counters.Length; ++i)
            {
                if (counters[i] < min)
                {
                    counters[i] = min;
                }
            }

            return counters;
        }
    }
}
