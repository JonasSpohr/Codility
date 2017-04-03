using System.Collections.Generic;

namespace Codility
{
    /*
     
A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:

S is empty;
S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
S has the form "VW" where V and W are properly nested strings.
For example, the string "{[()()]}" is properly nested but "([)()]" is not.

Write a function:

class Solution { public int solution(string S); }
that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.

For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0, as explained above.

Assume that:

N is an integer within the range [0..200,000];
string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".
Complexity:

expected worst-case time complexity is O(N);
expected worst-case space complexity is O(N) (not counting the storage required for input arguments).         
    
    */

    public class Brackets
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
                    case ']':
                        if (ss.Count > 0 && ss.Peek().Equals('['))
                            ss.Pop();
                        else
                            return 0;
                        break;
                    case '}':
                        if (ss.Count > 0 && ss.Peek().Equals('{'))
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
