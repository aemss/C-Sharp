
public class Birlik
{
    protected String isim;

    public Birlik(String isim)
    { this.isim = isim; }

    public virtual void SefereCik()
    {
        Console.WriteLine($"{isim} adlı birlik yola çıktı.");

    }

}

