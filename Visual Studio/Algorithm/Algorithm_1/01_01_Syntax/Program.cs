namespace Algorithm;

using System.Collections.Generic;

class Program
{
    
    static void Main(string[] args)
    {
        /*
        // Definiton
        var sayilar = new List<int>();

        int x = 55;

        int[] Seri = new int[] {70,80,90};

        //Add elemenets to the list
        sayilar.Add(10);
        sayilar.Add(15);
        sayilar.Add(20);
        sayilar.Add(x);
        sayilar.AddRange(Seri);
         
        foreach(var sayi in sayilar)
        {
            Console.WriteLine($"{sayi, -5}");
        }
       
        //int c = Karsilastir(3,5);
        //Console.WriteLine(c);
        //double d = KareAl(5);
        //Console.WriteLine(d);
        //double toplam = SeriToplami(5.3, 10.2, 15.5);
        //Console.WriteLine("{0,5:0.##}",toplam);
        //var odenecekMiktar = SatisYap(100);
        //Console.WriteLine(odenecekMiktar);
        //var odenecekMiktar2 = SatisYap(100, .1);
        //Console.WriteLine("{0,5:.##}",odenecekMiktar2);
        //int x = 10;
        //int y = 20;
        //Console.WriteLine("{0},{1}",x,y);
        //Degistir(ref x,ref  y);
        var sehirler = new List<string>()
        {
            "Ankara",
            "Van",
            "Yalova",
            "Edirne"
        };
        // Lambda
        sehirler.ForEach(s => Console.WriteLine(s));

        Console.WriteLine(new String('-',50));

        var iller = sehirler;
        iller.ForEach(s => Console.WriteLine(s));

        Console.WriteLine(new String('-',50));
        sehirler.Add("Sinop");
        sehirler.ForEach(s => Console.WriteLine(s));
        */
        // 8-Bit Integer
        Console.WriteLine(nameof(SByte));
        Console.WriteLine($"Alt Limit: {SByte.MinValue}");
        Console.WriteLine($"Üst Limit: {SByte.MaxValue}");
    }

    
}

