using System.Text;

// Answer 1
public class Solution1
{
    public string AddBinary(string a, string b)
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        StringBuilder result= new StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;
            if (i >= 0)
            {
                sum += a[i] - '0';
                i--;
            }
            if(j >= 0)
            {
                sum += b[j] - '0';
                j--;
            }

            result.Append(sum % 2);

            carry = sum / 2;
        }
        char[] charArray = result.ToString().ToCharArray();
        Array.Reverse(charArray);

        return new string(charArray);
    }
}


// Answer 2 
public class Solution2
{
    public int MySqrt(int x)
    {
        int left = 1;
        int right = x;
        while(left <= right)
        {
         int mid = left + (right - left) / 2;
         if (mid == x / mid)
            return mid;

         else if (mid < x / mid)
            left = mid + 1;

         else if (mid > x / mid)
            right = mid - 1;

        }
        return right;   
    }
}



// Answer 3 
public class Solution3
{
    public int ClimbStairs(int n)
    {
        
        if (n <= 2) return n;

        int onceki2 = 1; 
        int onceki1 = 2;  

        for (int i = 3; i <= n; i++)
        {
            int simdiki = onceki1 + onceki2; 
            onceki2 = onceki1;               
            onceki1 = simdiki;
        }

        return onceki1;
    }
}







