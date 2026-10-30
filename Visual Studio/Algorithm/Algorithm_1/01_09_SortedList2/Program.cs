namespace _01_09_SortedList2;

using System.Collections;

internal class Program
{
    static void Main(string[] args)
    {
        // 
        var kitapİcerigi = new SortedList();
        kitapİcerigi.Add(1,"Önsöz");
        kitapİcerigi.Add(50,"Değişkenler");
        kitapİcerigi.Add(40,"Operatörler");
        kitapİcerigi.Add(60,"Döngüler");
        kitapİcerigi.Add(45, "İlişkisel Operatörler");

        Console.WriteLine("İçindekiler");
        Console.WriteLine(new String('-',25));
        foreach (DictionaryEntry item in kitapİcerigi)
        {
            Console.WriteLine($"{item.Key,5}  {item.Value,-20}");
        }
    }
}
