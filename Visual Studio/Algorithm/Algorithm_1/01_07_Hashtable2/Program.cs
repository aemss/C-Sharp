namespace _01_07_Hashtable2;

using System.Collections;
internal class Program
{
    static void Main(string[] args)
    {
         
        Console.WriteLine("Başlık Giriniz.");
        string baslik = Console.ReadLine();

        baslik = baslik.ToLower();

        //HashTable
        var karakterSeti = new Hashtable()
        {
            { 'ç', 'c' },
            { 'ı', 'i' },
            { 'ö', 'o' },
            { 'ü', 'u' },
            { 'ğ', 'g' },
            { ' ', '-' },
            { '\'', '-'},
            { '.', '-' }
        };
        foreach (DictionaryEntry item in karakterSeti)
        {
            baslik = baslik.Replace((char)(item.Key),(char)item.Value);
        }

        Console.WriteLine(baslik);
    }
}

