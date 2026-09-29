
/*
// --- 1. ÇALIŞAN KODLAR (DOSYANIN EN ÜSTÜ) ---

List<Asker> ordu = new List<Asker>();


Dictionary<int, string> esyalistesi = new Dictionary<int, string>();

esyalistesi.Add(99, "Uzun Kılıç");
esyalistesi.Add(151, "Yay");

Console.WriteLine(esyalistesi[99]);

Asker piyade = new Asker("Nord Kahramanı",  60);
Asker Süvari = new Asker("Sarranid Memlük", 59);
Asker Okçu = new Asker("Rodok Keskin Nişancısı", 60);

Console.WriteLine("Savaş Alanındaki toplam asker sayısı: " + Asker.ToplamAskerSayisi);


ordu.Add(piyade);
ordu.Add(Süvari);
ordu.Add(Okçu);

foreach(Asker SiradakiAsker in ordu) 
{
    SiradakiAsker.CandurumunuGoster();
    SiradakiAsker.HasarAl(25);

    Console.WriteLine($"{SiradakiAsker.BirlikAdi}'nın Yeni Canı: " + SiradakiAsker.CaniSoyle());
}

Console.WriteLine("\n----------------------------------\n");

// 2. BÖLÜM: SÖZLÜK (Dictionary) KULLANIMI

Dictionary<string, Asker> lordKayitlari = new Dictionary<string, Asker>();

lordKayitlari.Add("Kral Harlaus", new Asker("Svadya Kralı", 60));
lordKayitlari.Add("Sancar Han", new Asker("Kergit Hanı", 60));

Console.WriteLine("Kral Harlaus'un verileri açılıyor....");
lordKayitlari["Kral Harlaus"].CandurumunuGoster();

Console.WriteLine("\n----------------------------------\n");

// --- 3. ŞABLON KISMI (DOSYANIN EN ALTI) ---

class Asker
{
    public string BirlikAdi;
    private int can;

    public static int ToplamAskerSayisi = 0;

    public int CaniSoyle()
    {
        return can;
    }

    // Constructor (Yapıcı Metot)
    public Asker(string BaslangicIsmi, int BaslangicCani)
    {
        BirlikAdi = BaslangicIsmi;
        can = BaslangicCani;

        ToplamAskerSayisi++;
    }


    public void HasarAl(int HasarMiktari)
    {
        can -= HasarMiktari;
        if (can < 0)
        {
            can = 0;
        }
    }

    public void CandurumunuGoster()
    {
        Console.WriteLine(BirlikAdi + " isimli askerin canı: " + can);
    }
}


*/

Dictionary<string,Yoldas> Yoldaslar = new Dictionary<string,Yoldas>();

Yoldaslar.Add("Matheld", new Yoldas("Matheld",90));
Yoldaslar.Add("Ymira", new Yoldas("Ymira",90));

List<Yoldas> ordu = new List<Yoldas>();

ordu.Add(Yoldaslar["Matheld"]);
ordu.Add(Yoldaslar["Ymira"]);

Console.WriteLine("--- SAVAŞ SONU RAPORU ---");

foreach(Yoldas siradaki in  ordu)
{
    siradaki.HasarAl(20);
    Console.WriteLine(siradaki.İsim + " İsimli yoldaşın yeni canı : " + siradaki.CaniSoyle());
    
}

Console.WriteLine("Ordudaki yoldaş sayısı: " + Yoldas.HandakiYoldaslar);

class Yoldas 
{
    public string İsim;
    private int Can;
    public static int HandakiYoldaslar = 0;
    public int CaniSoyle() {
        return Can;
    }
    public Yoldas(string Baslangıcİsmi,  int BaslangıcCan) 
    {
        İsim = Baslangıcİsmi;
        Can = BaslangıcCan;
        HandakiYoldaslar++;
    }

    public void HasarAl(int HasarMiktari)
    {
        if (Can < 0)
            Can = 0;

    }


    
}


