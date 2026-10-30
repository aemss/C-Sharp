namespace _01_16_SortedSet;

using System.Collections.Generic;
using System.Threading.Channels;

internal class Program
{
    static void Main(string[] args)
    {
        // Küme İşlemleri
        // var A = new SortedSet<int>() {1,2,3,4 };
        var A = new SortedSet<int>(RastgeleSayiUret(10));
        // var B = new SortedSet<int>() {1,2,5,6 };
        var B = new SortedSet<int>(RastgeleSayiUret(10));
        
        #region
        Console.WriteLine("A kümesi");
        foreach (int sayi in A)
        {
            Console.WriteLine($"{sayi,5}");
        }
     
        Console.WriteLine("B kümesi");
        foreach (int sayi in B)
        {
            Console.Write($"{sayi,5}");
        }
        #endregion


        // A.UnionWith(B);   // Birleşim
        // A.IntersectWith(B); // Kesişim
        // A.ExceptWith(B);
         A.SymmetricExceptWith(B); // Kesişim dışındaki elemanlar
        A.IsSubsetOf(B); // B'nin alt kümesi mi ? 

        Console.WriteLine();
        Console.WriteLine("A Birleşim B:\n");
        foreach (var item in A)
        {
            Console.Write($"{item,5}");
        }
        Console.WriteLine();
        Console.WriteLine("Toplam sayisi: {0}", A.Count);
    }

    
    static List<int> RastgeleSayiUret(int n)
    {
        var list = new List<int>();
        var r = new Random();
        for (int i = 0; i < n; i++)
            list.Add(r.Next(0,100));
        return list;
            
        
        
    }


    private static void SortedSetExample()
    {
        var sayilar = new List<int>();
        var r = new Random();

        Console.WriteLine();
        for (int i = 0; i < 100; i++)
        {
            sayilar.Add(r.Next(0, 10));
            Console.Write($"{sayilar[i],-3}");
        }
        Console.WriteLine();
        //Listedeki benzersiz elemanları bulma.
        var benzersizSayiListesi = new SortedSet<int>(sayilar);

        Console.WriteLine();
        Console.WriteLine("\nBenzersiz sayı listesi.\n");
        foreach (int sayi in benzersizSayiListesi)
        {
            Console.Write($"{sayi,-3}");
        }
        Console.WriteLine("Benzersiz {0} sayı var.", benzersizSayiListesi.Count);
    }

    private static void SortedSetBasics()
    {
        var list = new SortedSet<string>();


        if (list.Add("Mehmet"))
        {
            Console.WriteLine("Mehmet eklendi.");
        }
        else Console.WriteLine("Ekleme başarısız.");

        Console.WriteLine(list.Add("Ahmet") == true ?
            "Ahmet Eklendi." : "Ekleme başarısız.");

        list.Add("Enes");
        list.Add("Yusuf");
        list.Add("Fatih");

        Console.WriteLine("\nisimler listesi\n");
        foreach (string i in list)
        {
            Console.WriteLine(i);
        }
        list.Remove("Fatih");
        //list.RemoveWhere(deger => deger.Contains("e"));
        list.RemoveWhere(deger => deger.StartsWith("E"));

        Console.WriteLine("\nisimler listesi\n");
        foreach (string i in list)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Eleman saıyısı: {0,3}", list.Count());
    }
}
