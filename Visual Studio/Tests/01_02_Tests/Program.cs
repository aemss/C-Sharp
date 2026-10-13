using System.Text;

// Answer 1

public class Solution
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

