namespace _01_03_Struct;



internal class Program
{
    static void Main(string[] args)
    {
        
        //Ogrenci ogr = new Ogrenci();
        //ogr.Numara = 101;
        //ogr.Adi = "Ahmet";
        //ogr.Soyadi = "Yıldız";
        //ogr.Cinsiyet = true;

        // 2.Alternatif Kullanım
        //var ogr3 = new Ogrenci(100,"Enes","Mot",true);

        // 3. Alternatif kullanım
        //var ogr4 = new Ogrenci(15,"Yusuf","Kocagöbek",false);

        //var ogr2 = new Ogrenci()
        //{
        //    Numara = 200,
        //    Adi = "Memo",
        //    Soyadi = "Kalyoncuoğlu",
        //    Cinsiyet = true
        //};

        //Console.WriteLine($"{ogr.Numara} " +
        //    $"{ogr.Adi} " +
        //    $"{ogr.Soyadi} " +
        //    $"{ogr.Cinsiyet} ");

        var ogrenciListesi = new List<Ogrenci>()
        {
            new Ogrenci(100,"Enes","Mont",true),
            new Ogrenci(31,"Yusuf","Kocagöbek",false),
            new Ogrenci(69,"Sefo","Açgün"),
            new Ogrenci(3169,"Latifiko","Körünoğlu",false)
        };

        ogrenciListesi.ForEach(ogrenci => { Console.WriteLine(ogrenci); });

        //foreach (var ogrenci in ogrenciListesi)
        //{
        //    Console.WriteLine(ogrenci);
        //}
        
    } 
        




}
