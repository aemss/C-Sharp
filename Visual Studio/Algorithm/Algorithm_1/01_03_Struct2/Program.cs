namespace _01_03_Struct2;
public struct Nokta
{
    public int X { get; set; }
    public int Y { get; set; }
    public override string ToString()
    {
        return $"{X}, {Y}";
    }
    public Nokta(int x, int y)
    {
        X = x;
        Y = y;
    }
    // Yeni Üye(method) kaydı ->
    public void SetOrigin()
    {
        this.X = 0; //this Noktayı temsil eder.(yani ana strcutı/classı/interface'i)
        Y = 0;      // Yazmasak da anlar.
    }
    public void Degistir()
    {
        var gecici = this.X; // this'siz de yazabilirdik.
        X = Y;
        Y = gecici;
    }

     
} 

internal class Program
{


    static void Main(string[] args)
    {
        // strcut -> değer tipli
        var n1 = new Nokta(3,4);
        Console.WriteLine(n1);
        n1.Degistir();
        Console.WriteLine(n1);
        var n2 = n1;
        Console.WriteLine(n2);
    }
}


