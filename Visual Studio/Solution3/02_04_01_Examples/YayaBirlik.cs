
public class YayaBirlik : Birlik
{
    protected String SilahTipi;
    public YayaBirlik(string isim,String SilahTipi) : base(isim)
    {
        this.SilahTipi = SilahTipi;
    }


    public override void SefereCik()
    {
        //base.SefereCik();
        Console.WriteLine($"{isim} adlı birlik, {SilahTipi} kuşanarak saldırıya geçti.");

    }

}
