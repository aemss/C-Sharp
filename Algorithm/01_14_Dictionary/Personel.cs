namespace _01_14_Dictionary;

public class Personel
{
    public int SicilNo { get; set; }
    public String Adi { get; set; }
    public String Soyadi { get; set; }
    public Decimal Maas { get; set; }

    public Personel(string adi,string soyadi,decimal maas)
    {
        Adi = adi;
        Soyadi = soyadi;
        Maas = maas;
    }

    public override string ToString()
    {
        return $" {Adi,-10} {Soyadi,-15} {Maas,-10}";
    }


}
