namespace _01_06_Hashtable;

using System.Collections;

internal class Program
{
    
    static void Main(string[] args)
    {
        
        var sehirler = new Hashtable();

        sehirler.Add(6, "Ankara");
        sehirler.Add(34, "İstanbul");
        sehirler.Add(55, "Samsun");
        sehirler.Add(23, "Elazığ");

        foreach (DictionaryEntry sehir in sehirler)
        {
            Console.WriteLine($"{sehir.Key} - {sehir.Value,-15}");
        }

        Console.WriteLine("\nKeys\n");
        var anahtarlar = sehirler.Keys;
        foreach (var item in anahtarlar)
        {
            Console.WriteLine(item);
        }

        // Değerler
        Console.WriteLine("\nValues\n");
        ICollection degerler = sehirler.Values;
        foreach (var item in degerler)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(sehirler[55]);
        sehirler.Remove(34);

        foreach (DictionaryEntry sehir in sehirler)
        {
            Console.WriteLine($"{sehir.Key} - {sehir.Value,-15}");
        }
        
    }
}
