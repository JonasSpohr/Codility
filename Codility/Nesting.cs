using System.Collections.Generic;

namespace Codility
{
    public class Nesting
    {
        public int run(string S)
        {
            Stack<char> ss = new Stack<char>();
            if (string.IsNullOrWhiteSpace(S))
                return 1;

            foreach (char c in S)
            {
                switch (c)
                {
                    case ')':
                        if (ss.Count > 0 && ss.Peek().Equals('('))
                            ss.Pop();
                        else
                            return 0;
                        break;
                    default:
                        ss.Push(c);
                        break;
                }
            }

            return ss.Count == 0 ? 1 : 0;
        }
    }
}
