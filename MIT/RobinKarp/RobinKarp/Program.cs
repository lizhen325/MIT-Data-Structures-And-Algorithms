using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobinKarp
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "she shell me";
            string pattern = "a";
            BruteForce.FindWord(words, pattern);


            string source = "ILoveE";
            string subString = "eE";
            int res = KMP.KMPSearch(source, subString);
            Console.Write(res);
            Console.ReadKey();
        }
    }
}
