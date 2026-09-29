
var ogrenciler = new string[3];
var notlar = new int[3];

Console.Write("1. Öğrencinin adı:");
ogrenciler[0] = Console.ReadLine() ?? "Öğrenci adı tanımlanmadı (null)";

Console.WriteLine("1. Öğrencinin notu:");
notlar[0] = Convert.ToInt32(Console.ReadLine() ?? "null");


Console.Write("2. Öğrencinin adı");
ogrenciler[1] = Console.ReadLine() ?? "Öğrenci adı tanımlanmadı (null)";

Console.WriteLine("2. Öğrencinin notu:");
notlar[1] = Convert.ToInt32(Console.ReadLine() ?? "null");


Console.Write("3. Öğrencinin adı");
ogrenciler[2] = Console.ReadLine() ?? "Öğrenci adı tanımlanmadı (null)";

Console.WriteLine("3. Öğrencinin notu:");
notlar[2] = Convert.ToInt32(Console.ReadLine() ?? "null");

foreach(var ogrenci in ogrenciler[..2])
{
    Console.WriteLine(ogrenci);
}

foreach (var not in notlar[..2])
{
    Console.WriteLine(not);
}

Console.WriteLine("Öğrenciler dizisinin eleman sayısı" + ogrenciler.Length);
Console.WriteLine(notlar.Length);

var not1 = notlar[0];
var not2 = notlar[1];
var not3 = notlar[2];   

var ortalama = (not1 + not2 + not3) / 3;

Console.WriteLine("Öğrencilerin not ortalaması" + ortalama);
 
