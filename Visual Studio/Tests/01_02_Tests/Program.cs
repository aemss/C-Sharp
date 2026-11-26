using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text;

// Answer 1
string AddBinary(string a, string b)
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

// Answer 2 
int MySqrt(int x)
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

// Answer 3 
int ClimbStairs(int n)
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

// Answer 4
string MergeAlternately(string word1, string word2)
    {
        
        StringBuilder sonuc = new StringBuilder();
        
        for (int i = 0; i < word1.Length || i < word2.Length; i++)
        {

            if (i < word1.Length)
                sonuc.Append(word1[i]);



            if (i < word2.Length)
                sonuc.Append(word2[i]);

        }

        return sonuc.ToString();
    }

// Answer 5 
string GcdOfStrings(string str1, string str2)
    {
        int ebobuzunlugu = 0;
        if (str1 + str2 != str2 + str1)
        {
            return "";
        }

        ebobuzunlugu = Ebob(str1.Length, str2.Length);

        return str1.Substring(0, ebobuzunlugu);



    }
int Ebob(int a,int b)
    {
        while(b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

// Answer 6

IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int a = candies.Max();

        List<bool> sonucListesi = new List<bool>();

        foreach (var item in candies)
        {
            if (item + extraCandies >= a)
                sonucListesi.Add(true);
            else
                sonucListesi.Add(false);
        }

        return sonucListesi;
    }

// Answer 7

bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        for (int i = 0; i < flowerbed.Length; i++)
        {

            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i] = 1;
                n--;
            }
            if (n <= 0) return true;
        }
        return n <= 0;

    }

// Answer 8
string ReverseVowels(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        HashSet<char> vowels = new HashSet<char> 
        { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        char[] chars = s.ToCharArray();

        while (left<right)
        {
            if (!vowels.Contains(chars[left]))
                left++;
            
            
                
            else if (!vowels.Contains(chars[right]))
                right--;

            else
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }
        }

        return new string(chars);
    }

// Answer 9
int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++) 
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }
        return new int[] { } ;
    }

// Answer 10
    bool CheckRecord(string s)
    {
        char Absent = 'A';
        char Late = 'L';
        char Present = 'P';

        int absentCount = 0;
        int lateStreak = 0;


        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'A')
            {
                absentCount++;
                if (absentCount >= 2)
                    return false;
            }
            if (s[i] == 'L')
            {
                lateStreak++;
                if (lateStreak >= 3)
                    return false;

            }
            else
                lateStreak = 0;
        }
        return true;
    }

    bool CheckRecord2(string s)
    {
        if (s.Count(c => c == 'A') >= 2  || s.Contains("LLL"))
            return false;
       return true; 
    }
