

internal class KaraDelik : GokCismi
{
    public double OlayUfkuCapi { get; set; }
    public KaraDelik(string Baslangıcİsim, string BaslangıcUzaklık, double BaslangicOlayUfku) : base(Baslangıcİsim, BaslangıcUzaklık)
    {
        OlayUfkuCapi = BaslangicOlayUfku;
    }

    public void TehlikeMetodu()
    {
        Console.WriteLine($"Dikkat: {Isim} olay ufkuna giriyoruz!");
    }


}

