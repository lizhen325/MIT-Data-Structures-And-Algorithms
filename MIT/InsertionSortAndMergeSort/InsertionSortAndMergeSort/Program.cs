using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAndMergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 7, 3, 2, 4, 6, 8 };
            int[] sorted = new int[nums.Length];
            MergeSort mearge = new MergeSort();
            mearge.Merge(nums,0,nums.Length,sorted);
            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine(nums[i]);
            Console.ReadKey();
        }
    }
}
