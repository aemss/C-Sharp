namespace _01_10_List;

using System.Collections.Generic;

public class Sehir : IComparable<Sehir>
{
    public int Plaka { get; set; }
    public String SehirAdi { get; set; }


    public Sehir(int plaka, string sehirAdi)
    {
        Plaka = plaka;
        SehirAdi = sehirAdi;
    }

    public override string ToString()
    {
        
        return $"{Plaka} - {SehirAdi}";
    }

    public int CompareTo(Sehir other)
    {
        if (this.Plaka < other.Plaka)
        {
            return -1;
        }
        else if (this.Plaka == other.Plaka)
        {
            return 0;
        }
        else
            return 1;
    
    }

}

internal class Program
{
    static void Main(string[] args)
    {
        var sayilar = new List<int>() {5,151,12,43,32,2,53,44 };
        sayilar.Sort();
        sayilar.ForEach(sayi => Console.WriteLine(sayi));

        // Sehir Listesi
        var sehirler = new List<Sehir>() 
        {
            new Sehir(77,"Yalova"),
            new Sehir(16,"Bursa"),
            new Sehir(35,"İzmir"),
        };

        sehirler.Add(new Sehir(1, "Adana"));
        sehirler.Sort();
        sehirler.ForEach(sehir => Console.WriteLine(sehir));
    }
}
 