namespace _01_08_SortedList;
using System.Collections;

internal class Program
{
    static void Main(string[] args)
    {
        var list = new SortedList() 
        {
            {1, "Bir" },
            {2, "İki" },
            {3, "Üç" },
            {8, "Sekiz" },
            {5, "Beş" }
        };

        list.Add(7, "Yedi");
        list.RemoveAt(2);

        foreach (DictionaryEntry item in list)
        {
            Console.WriteLine($"{item.Key} - {item.Value} ");
        }

        Console.WriteLine("Listenin eleman sayısı: " + list.Count);
        Console.WriteLine("Listenin kapasitesi: {0} ",  list.Capacity);
        list.TrimToSize();
        Console.WriteLine("Listenin kapasitesi: " + list.Capacity);

        Console.WriteLine(list[4]);
        Console.WriteLine(list.GetByIndex(1));
    
        Console.WriteLine(list.GetKey(1));

        // Liste sonundaki elemanı alma
        Console.WriteLine(list.GetKey(list.Count - 1));

        var anahtarlar = list.Keys;

        Console.WriteLine("\nKeys:\n");
        foreach (var item in anahtarlar)
        {
            Console.WriteLine(item);
        }
    

        var degerler = list.Values;

        Console.WriteLine("\nValues:\n");
        foreach (var item in degerler )
        {
            Console.WriteLine(item);
        }

        if (list.ContainsKey(1)) list[0] = "One";

        foreach (DictionaryEntry item in list)
        {
            Console.WriteLine($"{item.Key} - {item.Value} ");
        }

    }
}
