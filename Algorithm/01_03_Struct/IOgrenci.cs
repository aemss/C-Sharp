namespace _01_03_Struct;

public struct Ogrenci
{
    public int Numara { get; set; }
    public string Adi { get; set; }
    public String Soyadi { get; set; }
    public bool Cinsiyet { get; set; }

    //Constructor
    public Ogrenci(int numara, string adi, String soyadi, bool cinsiyeti = true)
    {
        Numara = numara;
        Adi = adi;
        Soyadi = soyadi;
        Cinsiyet = cinsiyeti;
    }
    public override string ToString() 
    {
        return $"Numarası: {Numara}\n" +
            $"Adı: {Adi}\n" +
            $"Soyadı: {Soyadi}\n" +
            "Cinsiyeti: " + (Cinsiyet ? "Erkek\n" : "Kız\n");
    }
    
}