using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
 

public class Solution1 {
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



public class Solution2 {
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


public class Solution3 {

    public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}
    public ListNode DeleteDuplicates(ListNode head) 
    {
        ListNode current = head;

        while(current != null && current.next != null)
        {
            if (current.val == current.next.val) 
                current.next = current.next.next; // Oku kopyanın bir sonrasına bağla (silme işlemi)

 
            else 
                current = current.next; // Her şey yolundaysa bir sonraki düğüme geç
        }

        return head;


    }
}