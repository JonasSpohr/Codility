using System.Collections.Generic;

namespace Codility
{
    public class Fish
    {
        public int run(int[] A, int[] B)
        {
            Stack<int> s = new Stack<int>();
            int l = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 1)
                {
                    s.Push(A[i]);
                }
                else
                {
                    while (s.Count > 0)
                    {
                        if (s.Peek() < A[i])
                            s.Pop();
                        else
                            break;
                    }

                    if (s.Count == 0)
                        l += 1;
                }
            }

            return l + s.Count;
        }
    }
}
