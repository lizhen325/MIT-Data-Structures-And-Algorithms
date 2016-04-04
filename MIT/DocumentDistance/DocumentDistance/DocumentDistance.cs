using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentDistance
{
    public class DocumentDistance
    {
        private Dictionary<string, int> map;

        public string[] SplitWords(string filePath)
        {
            string allText = File.ReadAllText(filePath);
            string[] words = allText.Split(' ');
            return words;
        }

        public Dictionary<string, int> GetWordFrequency(string[] words)
        {
            map = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (map.ContainsKey(word))
                    map[word]++;
                else
                    map[word] = 1;
            }
            return map;
        }

        public int ComputeInnerProduct(Dictionary<string, int> first, Dictionary<string, int> second)
        {
            int sum = 0;
            foreach (var key in first.Keys)
            {
                if (second.ContainsKey(key))
                    sum += first[key] * second[key];
            }
            return sum;
        }

        public double ComputeDistance(Dictionary<string, int> first, Dictionary<string, int> second)
        {
            int numerator = ComputeInnerProduct(first, second);
            double denominator = Math.Sqrt(ComputeInnerProduct(first, first) * ComputeInnerProduct(second, second));
            return Math.Acos(numerator / denominator);
        }
    }
}
