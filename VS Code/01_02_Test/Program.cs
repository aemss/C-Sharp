using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
 
/*
public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        int k = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val) 
            {
                nums[k] = nums[i];
                k++;    
            }
        }
        return k;
    }
}

*/

public class Solution {
    public int SearchInsert(int[] nums, int target) 
    {
        int left = 0;
        int right = nums.Length - 1;
        
        while (left <= right) 
        {
            int mid = left + (right - left) / 2;

            if(nums[mid] == target) 
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid +1;
            }
            else
                right = mid - 1;
        }
         return left;       
    }
}
