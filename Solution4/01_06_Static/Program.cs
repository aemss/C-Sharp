
using Static;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"PI: {MathHelper.PI} ");
        Console.WriteLine($"5'in karesi: {MathHelper.Sqaure(5)}");

        Counter c1 = new Counter();
        Counter c2 = new Counter();
        Counter c3 = new Counter();

        Console.WriteLine($"Toplam sayaç sayısı: {Counter.Count}");

    }
}



 