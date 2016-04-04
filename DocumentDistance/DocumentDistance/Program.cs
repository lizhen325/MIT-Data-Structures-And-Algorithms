using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentDistance document = new DocumentDistance();
            string[] words1 = document.SplitWords(@"document1.txt");
            Dictionary<string, int> dic1 = document.GetWordFrequency(words1);
            string[] words2 = document.SplitWords(@"document2.txt");
            Dictionary<string, int> dic2 = document.GetWordFrequency(words2);
            double angle = document.ComputeDistance(dic1, dic2);
            Console.Write(angle);
            Console.ReadKey();
        }
    }
}
