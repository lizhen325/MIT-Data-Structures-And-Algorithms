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
            string pattern = "shele";
            BruteForce.FindWord(words, pattern);
            Console.ReadKey();
        }
    }
}
