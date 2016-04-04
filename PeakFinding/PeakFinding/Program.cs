using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakFinding
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nums = { 1, 2, 3};
            int result = OneDPeakFinding.FindPeakFind(nums);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
