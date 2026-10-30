namespace _01_11_Stack;

using System;
using System.Collections.Generic;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        var sayiYigini = new Stack<int>();
        sayiYigini.Push(sayi);
    
        while(sayi > 0)
        {
            int k = sayi % 10;
            sayiYigini.Push(k);
            sayi /= 10;
        }
        int i = 0;
        int n = sayiYigini.Count - 1;
        foreach (var item in sayiYigini)
        {
            Console.WriteLine($"\t{item,7} x" +
                $" {Math.Pow(10,n-i),7}\t = " +
                $"{item*Math.Pow(10,n-i),7}");
            i++;
        }
    
    
    }




    private static void YıgınOrnegi()
    {
        // Stack Tanımlama
        var karakterYigini = new Stack<char>();

        karakterYigini.Push('A');
        Console.WriteLine(karakterYigini.Peek());
        karakterYigini.Push('B');
        Console.WriteLine(karakterYigini.Peek());
        karakterYigini.Push('C');
        Console.WriteLine(karakterYigini.Peek());

        Console.WriteLine(karakterYigini.Pop() + " Yığından çıkartıldı.");
    }
    private static void Ornek2()
    {
        var karakteryigini = new Stack<char>();
        for (int i = 65; i <= 90; i++)
        {
            karakteryigini.Push((char)i);
            Console.WriteLine($"{karakteryigini.Peek()} yığına eklendi.");
            Console.WriteLine($"Yığındaki eleman sayısı: {karakteryigini.Count}");
        }
        // Ek Bilgi
        var dizi = karakteryigini.ToArray();

        Console.WriteLine("Yığından çıkartma işlemi için bir tuşa basınız.");
        Console.ReadKey();

        while (karakteryigini.Count > 0)
        {
            Console.WriteLine(karakteryigini.Pop() + " Yığından çıkarıldı.");
            Console.WriteLine($"Yığındaki eleman sayısı: {karakteryigini.Count}");
        }
    }
}
