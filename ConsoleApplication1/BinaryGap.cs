using System;

namespace TopTalChallenge_JS
{
    public class BinaryGap
    {
        public int run(int N)
        {
            var number = Convert.ToString(N, 2);
            int max = 0;
            int bigger = 0;

            foreach (var c in number)
            {
                if (c.Equals('1'))
                {
                    bigger = max > bigger ? max : bigger;
                    max = 0;
                }
                else
                {
                    max += 1;
                }
            }

            return bigger;
        }
    }
}
