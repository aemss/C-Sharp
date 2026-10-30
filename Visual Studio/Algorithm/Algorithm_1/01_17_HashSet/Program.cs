namespace _01_17_HashSet;
using System.Collections;
using System.Collections.Generic;
internal class Program
{
    static void Main(string[] args)
    {
        var sesliHarf = new HashSet<char>()
        {
            'e','ı','i','u','ü','o','ö','b'
        };

        sesliHarf.Add('a');
        Console.WriteLine();

        sesliHarf.Remove('b');
        KoleksiyonYazdir(sesliHarf);

        var alfabe = new List<char>();
        for (int i = 97; i < 123; i++)
            alfabe.Add((char)i);
        KoleksiyonYazdir(alfabe);

        //sesliHarf.ExceptWith(alfabe);
        //sesliHarf.UnionWith(alfabe);
        // sesliHarf.IntersectWith(alfabe);
        sesliHarf.SymmetricExceptWith(alfabe);
        
        KoleksiyonYazdir(sesliHarf);
        Console.ReadKey();
    }

    static void KoleksiyonYazdir(IEnumerable koleksiyon)
    {
        Console.WriteLine();
        int i = 0;
        foreach (char c in koleksiyon)
        {
            Console.Write($"{c,5}");
            i++;
        }
        Console.WriteLine("\nEleman sayisi: "+ i);
        Console.WriteLine();
    }

}
