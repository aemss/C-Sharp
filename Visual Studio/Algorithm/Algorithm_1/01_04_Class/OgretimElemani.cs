namespace _01_04_Class;

internal partial class Program
{
    public class OgretimElemani
    {
        public int SicilNo { get; set; }
        public String Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }
        public OgretimElemani(int sicilno, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilno;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public override string ToString()
        {
            return $"{SicilNo,-5} " +
                $"{Adi,-10} " +
                $"{Soyadi,-10} " +
                (Cinsiyet == true ? "Erkek" : "Kız");
        }

    }


}
