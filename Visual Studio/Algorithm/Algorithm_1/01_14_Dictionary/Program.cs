using System.Threading.Tasks.Dataflow;

namespace _01_14_Dictionary;

internal class Program
{
    static void Main(string[] args)
    {
        var personelListesi = new Dictionary<int, Personel>()
        {
            {103,new Personel("Mehmet","Demir",72000) }

        };
        personelListesi.Add(100, new Personel("Enes","Mot",70000));
        personelListesi.Add(101, new Personel("Arda","Kaya",65000));
        
    
        foreach (var item in personelListesi)
        {
            Console.WriteLine(item);
        }
    
    }

    private static void DictionaryBasics()
    {
        var telefonKodları = new Dictionary<int, String>()
        {
            {332, "Konya" },
            {337, "Adıyaman" },
            {466, "Art" }
        };

        telefonKodları.Add(322, "Adana");
        telefonKodları.Add(212, "İstanbul");
        telefonKodları.Add(216, "Yalova");
        telefonKodları.Add(132, "Bursa");

        // Erişme
        telefonKodları[466] = "Artvin";

        if (!telefonKodları.ContainsKey(213))
        {
            Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil!");
            telefonKodları.Add(213, "Ankara");
            Console.WriteLine("Yeni Kod Eklendi");
        }
        else
            Console.WriteLine("Zaten mevcut.");

        //Contains Value
        if (!telefonKodları.ContainsValue("Malatya"))
        {
            Console.WriteLine("\aMalatya'nın kod bilgisi tanımlı değil!");
            telefonKodları.Add(339, "Malatya");
            Console.WriteLine("Yeni Kod Eklendi.");
        }


        foreach (var item in telefonKodları)
        {
            Console.WriteLine(item);
        }
    }
}
