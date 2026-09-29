
// Random

string[] takimlar = { "Galatasaray", "Fenerbahçe", "Beşiktaş", "Trabzonspor" };

var rnd = new Random();

int sayi = rnd.Next(4);

Console.WriteLine(sayi);
Console.WriteLine(takimlar[sayi]);
