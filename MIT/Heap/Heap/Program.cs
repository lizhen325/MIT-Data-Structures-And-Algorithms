using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,3,5,3,6,3,4,1,7 };
            HeapSorting heapsort = new HeapSorting();
            heapsort.HeapSort(nums);
            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i]);
            Console.ReadKey();
        }
    }
}
