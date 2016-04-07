using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobinKarp
{
    public class KMP
    {
        private static void GetNextVal(string str, int[] next)
        {
            int i = 0;
            int j = -1;
            next[0] = -1;
            while (i < str.Length - 1)
            {
                if (j == -1 || str[i] == str[j])
                {
                    i++;
                    j++;
                    next[i] = j;
                }
                else
                {
                    j = next[j];
                }
            }
        }

        public static int KMPSearch(string source, string pattern)
        {
            int i, j;
            int[] next = new int[pattern.Length];
            GetNextVal(pattern, next);
            i = 0;
            j = 0;
            while (i < source.Length && j < pattern.Length)
            {
                if (j == -1 || source[i] == pattern[j])
                {
                    ++i;
                    ++j;
                }
                else
                {
                    j = next[j];
                }
            }
            if (j == pattern.Length)
                return i - pattern.Length;
            return -1;
        }
    }
}
