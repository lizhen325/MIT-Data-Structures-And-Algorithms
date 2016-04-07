using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountringSortAndRadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0,2,3,2,4,6,5};
            int[] res = CountingSort.CountingSorting(nums);
            foreach (var i in res)
                Console.Write(i);
            Console.ReadKey();
        }
    }
}
