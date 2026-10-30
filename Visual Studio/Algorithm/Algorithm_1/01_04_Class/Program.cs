namespace _01_04_Class;

internal partial class Program
{
    static void Main(string[] args)
    {
        var liste1 = new List<OgretimElemani>() 
        {
            new OgretimElemani(100,"Ahmet","Yalçın",true),
            new OgretimElemani(101,"Ahmet","Keriz",false),
            new OgretimElemani(101,"Said","Tekin",true),
            new OgretimElemani(15,"Enes","Mont",true)
        };

        Console.WriteLine("Liste 1 \n");
        liste1.ForEach(eleman =>  Console.WriteLine(eleman));
        List<OgretimElemani> liste2 = liste1;

        Console.WriteLine("\nListe 2\n ");
        liste2.ForEach(eleman => Console.WriteLine(eleman));

        liste2.Add(new OgretimElemani(10,"Mehmet","Emin",true));
        Console.WriteLine("Liste 2'ye ekleme yapıldı.");

        Console.WriteLine("\nListe 2\n ");
        liste2.ForEach(eleman => Console.WriteLine(eleman));

        Console.WriteLine("Liste 1 \n");
        liste1.ForEach(eleman => Console.WriteLine(eleman));

    }


}
