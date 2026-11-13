using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
 

public class Solution1
{
    public string LongestCommonPrefix(string[] strs)
    {
        if(strs == null || strs.Length == 0)
            return "";

        string prefix = strs[0];

        for(int i = 1; i < strs.Length; i++)
        {
            while(strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0,prefix.Length -1);

                if(prefix == "")
                    return "";
            }
        } 
     
        return prefix;
     
    }
}

public class Solution2 {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        // İki liste de bitene kadar (null olana kadar) döngüyü çalıştırır.
        while(list1 != null && list2 != null)
        {
            if(list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }
        if(list1 != null)
        {
            current.next = list1;
        }else if(list2 != null)
        {
            current.next= list2;
        }



        return dummy.next;
     }
}

public class Solution3 
{
    public string RemoveOuterParentheses(string s) 
    {
        StringBuilder sonuc = new StringBuilder();
        int opened = 0;

        foreach(char c in s)
        {
            if(c== '(')
            {
                if(opened > 0)
                {
                    sonuc.Append(c);
                }
                opened++;
            }
            else if (c == ')')
            {
                opened--;
                
                if(opened > 0)
                {
                    sonuc.Append(c);
                }

            }
        }
        return sonuc.ToString();
    }
}
   
public class Solution4 {
    public int RemoveDuplicates(int[] nums) 
    {
        if(nums.Length== 0) return 0;
        int k = 1;

        for(int i = 1; i< nums.Length; i++)
        {
            
            if(nums[i] != nums[i-1])
            {   
            nums[k] = nums[i];
            k++;
            }
        }
        return k;
    }
        

}
            
public class Solution5
{
    int[] sayilar = [12,25,32,13,9,27];
    int biggest;

    public Solution5()
    {
        biggest = sayilar[0];
     foreach(int s in sayilar)
      {
        if(s >biggest) 
        {
            biggest = s;
        }
      }
    }   


    

}


