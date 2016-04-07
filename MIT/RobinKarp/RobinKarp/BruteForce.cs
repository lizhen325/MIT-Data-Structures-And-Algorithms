using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobinKarp
{
    public class BruteForce
    {
        public static void FindWord(string words, string pattern)
        {
            int n = words.Length;
            int m = pattern.Length;
            if (n >= m)
            {
                for (int i = 0; i <= n - m; i++)
                {
                    int j = 0;
                    while (j < m && pattern[j] == words[i+j])
                    {
                        j++;
                    }
                    if(j==m)
                    {
                        Console.WriteLine("found");
                        return;
                    }
                }
            }
            Console.WriteLine("not found");
        }
    }
}
