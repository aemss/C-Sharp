
public class Arbaletci : YayaBirlik
{
    protected int Menzil;
    public Arbaletci(string isim, string SilahTipi,int Menzil) : base(isim, SilahTipi)
    {
        this.Menzil = Menzil;
    }

    public override void SefereCik()
    {
        base.SefereCik();
        Console.WriteLine($"{isim} isimli askerin silahi {SilahTipi} ve menzili {Menzil}");

    }
}




