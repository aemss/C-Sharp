// Answer 1

/*
 public class Solution
{
    public int LengthOfLastWord(string s)
    {
        char ends = ' ';
        int sayac = 0;
        for (int i =s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ends)
            {
                sayac++;
            }else if (s[i] == ends && sayac >0) 
            {
                break;
            }

        }

        return sayac;
    }
}

*/


// Answer 2
/*
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length-1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            else if(digits[i] == 9)
            {
                digits[i] = 0;

            }
        }
        int[] newDigit = new int[digits.Length + 1];
        newDigit[0] = 1;

        return newDigit;
    }
}
*/