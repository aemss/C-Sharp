
class GokCismi
{
    public String Isim { get; set; }
    public string Uzaklik { get; set; }
    public GokCismi(string Baslangıcİsim,string BaslangıcUzaklık)
    {
        Isim = Baslangıcİsim;
        Uzaklik = BaslangıcUzaklık;
    }


    public void BilgiYazdir()
    {
        Console.WriteLine($"{Isim} adlı Gök cisminin uzaklığı: {Uzaklik}");
    }
}



