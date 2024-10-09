/*
Given an array arr of non-negative numbers. The task is to find the first equilibrium point in an array. The equilibrium point in an array is an 
index (or position) such that the sum of all elements before that index is the same as the sum of elements after it.

Note: Return equilibrium point in 1-based indexing. Return -1 if no such point exists. 

Examples:

Input: arr[] = [1, 3, 5, 2, 2]      Output: 3 
Explanation: The equilibrium point is at position 3 as the sum of elements before it (1+3) = sum of elements after it (2+2). 

Input: arr[] = [1]                  Output: 1
Explanation: Since there's only one element hence it's only the equilibrium point.

Input: n = 3, arr[] = [1, 2, 3]     Output: -1
Explanation: There is no equilibrium point in the given array.

Expected Time Complexity: O(n)
Expected Auxiliary Space: O(1)

Constraints:
1 <= arr.size <= 105
0 <= arr[i] <= 109
*/

using System;
using System.Text;
using System.Collections.Generic;

namespace DSAConcepts
{
    public static class Equilibrium
    {
        public static int Point(int[] arr)
        {
            #region Solution with O(n) Complexity & O(1) Space complexity--- Optimized

            int start = 0, end = arr.Length - 1, sumLeft = 0, sumRight = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (sumLeft == sumRight && start == end)
                {
                    return arr[start];
                }

                if (start == end)
                    return -1;

                if (sumLeft < sumRight)
                {
                    sumLeft += arr[start];
                    start++;
                }
                else if (sumLeft > sumRight)
                {
                    sumRight += arr[end];
                    end--;
                }
                else
                {
                    sumRight += arr[end];
                    end--;

                    //or below code(either of these)
                    //  sumLeft += arr[start];  
                    // ++start;
                }
            }

            return -1;
            #endregion
        }
    }
}