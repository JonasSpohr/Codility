﻿using System;

namespace Codility
{
    /*
    
A positive integer D is a factor of a positive integer N if there exists an integer M such that N = D * M.

For example, 6 is a factor of 24, because M = 4 satisfies the above condition (24 = 6 * 4).

Write a function:

class Solution { public int solution(int N); }
that, given a positive integer N, returns the number of its factors.

For example, given N = 24, the function should return 8, because 24 has 8 factors, namely 1, 2, 3, 4, 6, 8, 12, 24. There are no other factors of 24.

Assume that:

N is an integer within the range [1..2,147,483,647].
Complexity:

expected worst-case time complexity is O(sqrt(N));
expected worst-case space complexity is O(1).         
         
    */
    public class CountFactors
    {
        public int run(int N)
        {
            int count = 0;

            if (N < 1)
                return 0;

            int sqrt = (int)Math.Ceiling(Math.Sqrt(N));

            for (int i = 1; i < sqrt; i++)
            {
                if (N % i == 0)
                    count += 2;
            }

            if (sqrt * sqrt == N)
            {
                count++;
            }

            return count;
        }

    }
}
