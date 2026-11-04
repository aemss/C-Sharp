

internal class Yıldız: GokCismi
{
    public int YuzeySicakligi { get; set; } 
    public Yıldız(string Baslangıcİsim, string BaslangıcUzaklık,int BaslangıcSicaklik) : base(Baslangıcİsim, BaslangıcUzaklık)
    {
        YuzeySicakligi = BaslangıcSicaklik;
    }

    public void ParlaklikDurumu()
    {
        Console.WriteLine($"{Isim} şu an {YuzeySicakligi} derecede parlıyor.");

    }


}


