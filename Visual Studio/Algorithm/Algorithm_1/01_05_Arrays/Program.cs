using System.Collections;

namespace _01_05_Arrays;

internal class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[] { 5, 3, 8, 10,2,18,23,44,55 };
        var numbers = Array.CreateInstance(typeof(int),5);
        var sayilar2 = new ArrayList(sayilar);

        sayilar.CopyTo(numbers, 0);
        Array.Sort(sayilar);
        Array.Sort(numbers);
        Array.Clear(sayilar, 2, 3);
        Array.Clear(sayilar, 2, 2);
        Console.WriteLine(Array.IndexOf(sayilar, 44));
        sayilar2.Sort();





        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"sayilar[{i}] = {sayilar[i]} - " +
                $"numbers[{i}] = {numbers.GetValue(i)}" +
                $"arr[{i} = " +
                $"{sayilar2[i]}");
        }
        
    }
}
