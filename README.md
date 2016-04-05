# MIT-Data-Structures-And-Algorithms

##[Chapter 1 Find a Peak Element in array](https://github.com/lizhen325/MIT-Data-Structures-And-Algorithms/tree/master/MIT/PeakFinding)

###Divide and Conquer Algorithm: O(logN) time complexity

>**pseudocode**
```
look at n/2 position
length = n/2;
if(arr[length]) < arr[length - 1])
  only look at left half to look for a peak
else if(arr[length] < arr[length + 1])
  only look at right half to look for a peak
else
  arr[length / 2] is a peak
```

##[Chapter 2 Document Distance](https://github.com/lizhen325/MIT-Data-Structures-And-Algorithms/tree/master/MIT/DocumentDistance)

###Algorithm:
>1. Split document into words
2. Compare word frequencies
3. Compute Distance: 
<code>
arccos(D1 * D2 / sqrt(D1 * D1) * sqrt(D2 * D2))
</code>

##[Charpter 3 InsertionSort & Merge Sort](https://github.com/lizhen325/MIT-Data-Structures-And-Algorithms/tree/master/MIT/InsertionSortAndMergeSort)

###InsertionSort Algoritm: O(n<sup>2</sup>) complexity
>For 1-> n insert arr[i] into sorted array arr[0 -> i-1] by pairwise swaps down to the correct position
>**pseudocode**
```
for i=1 to leanth arr
  for j=1 to j > 0
    if arr[j-1] > arr[j]
      swap arr[j] and arr[j-1]
  end for
end for
```
