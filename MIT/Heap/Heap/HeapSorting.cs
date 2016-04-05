using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class HeapSorting
    {
        public void MaxHeapify(int[] nums, int currentIndex, int heapSize)
        {
            int leftChild = 2 * currentIndex;
            int rightChild = 2 * currentIndex + 1;
            int max = currentIndex;
            if(leftChild < heapSize && nums[leftChild] > nums[max])
            {
                max = leftChild;
            }
            if(rightChild < heapSize && nums[rightChild] > nums[max])
            {
                max = rightChild;
            }
            if(currentIndex != max)
            {
                int temp = nums[currentIndex];
                nums[currentIndex] = nums[max];
                nums[max] = temp;
                MaxHeapify(nums, max, heapSize);
            }
        }

        public void BuildHeap(int[] nums)
        {
            for (int i = nums.Length/2 -1; i >= 0; i--)
                MaxHeapify(nums, i,nums.Length);
        }

        public void HeapSort(int[] nums)
        {
            BuildHeap(nums);
            for (int i = nums.Length - 1; i >0; i--)
            {
                int temp = nums[0];
                nums[0] = nums[i];
                nums[i] = temp;
                MaxHeapify(nums, 0 , i-1);
            }
        }
    }
}
